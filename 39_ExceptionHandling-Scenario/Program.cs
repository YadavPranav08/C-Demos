using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_ExceptionHandling_Scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = GetDeta();
            Console.WriteLine(result);

            string results = GetDeta1();
            Console.WriteLine(results);


            Console.ReadLine();
        }

        static string GetDeta()
        {
            try
            {
                
                return "TRY";
                
            }
            catch
            {
                
                return "catch";
                
            }
            finally
            {
                // return "finally";   // return statement is not possible in finally
            }
        }
        static string GetDeta1()
        {
            string result = "";
            try
            {
                result = "try";
                //return "TRY";
                return result;
            }
            catch
            {
                result = "catch";
                //return "catch";
                return result;
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
                 result = "Finally";   // return statement is not possible in finally
            }

            return result;
        }

    }
}
