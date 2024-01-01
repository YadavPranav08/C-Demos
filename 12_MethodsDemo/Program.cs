using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintA();            // calling method
            PrintB("Pranav");     // pranav=> method argument
            string name = "Yadav";
            PrintB(name);
            PrintC("pranav", "yadav");
            string firstname = "sandip", lastname = "pawar";
            PrintC(firstname, lastname);

            string result = PrintD("Shubham", "Yadav");
            Console.WriteLine($"PrintD() {result}");

            PrintE(true);
            PrintE(false);

            PrintF(null);
            int[] numbers = new int[] { 10, 20, 30, 40 };
            PrintF(numbers);

            Console.ReadLine();
        }

        // 1.  method without return without parameter
        static void PrintA()

        {
            Console.WriteLine("PrintA() Method Called");       // called method
        }

        // 2. method without return with parameter

        static void PrintB(string name)
        {
            Console.WriteLine($"PrintB() : Hello {name}");
        }

        // 3. method without return muiltiple parameter

        static void PrintC(string fn, string ln)
        {
            Console.WriteLine($"PrintC() {fn}  {ln}");
        }

        // 4. method with return with parameter

        static string PrintD(string fn, string ln)
        {
            return fn + " " + ln;
        }

        static void PrintE(bool isconfirmed)
        {
            if (!isconfirmed)
            {
                return;    // return will get return to main method
            }
            Console.WriteLine($"PrintE(){isconfirmed}: session allowed");
        }

        // sum of arrey example

        static void PrintF(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            { 
             int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"PrintF(): sum of number: {sum}");
            }
            else 
            {
                Console.WriteLine($"no nubers to add");
            }
        }
    }
}
