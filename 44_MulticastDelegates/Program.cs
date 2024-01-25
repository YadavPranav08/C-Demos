using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_MulticastDelegates
{
    delegate string Printdelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Printdelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;

            //string result = pd();
            //Console.WriteLine(result);

            Delegate[] delegates = pd.GetInvocationList();
            
            for (int i = 0; i < delegates.Length; i++)
            {
                try 
                {
                    var result = delegates[i].DynamicInvoke();
                    Console.WriteLine(result);
                }
                catch
                {
                    Console.WriteLine("Exception Occured");
                }
                
            }

            Console.ReadLine();
        }
        static string PrintA()
        {
            return "PrintA";
        }
        static string PrintB()
        {
            throw new Exception("INTENTIONALLY EXCEPTION THROWN");
            return "PrintB";
        }
        static string PrintC()
        {
            return "PrintC";
        }
    }
}
