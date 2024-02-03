using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _50_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // early binding
            //Customer c1 = new Customer();
            //c1.Print();

            // Late binding / Reflection

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type customer = assembly.GetType("_50_Reflection.Customer");

            object c = Activator.CreateInstance(customer);

            MethodInfo printA = customer.GetMethod("PrintA");

            printA.Invoke(c, null);

            MethodInfo printB = customer.GetMethod("PrintB");
            printB.Invoke(null, null);

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA() Method Called");
        }

        public static void PrintB()
        {
            Console.WriteLine("PrintB() Method Called");
        }
    }

}
