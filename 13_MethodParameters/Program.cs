using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pass by value
            int b0 = 10;
            PrintA(b0);
            Console.WriteLine(b0);

            // pass by referance
            int b1 = 10;      // in ref parameter it is mandetory to assign value in calling method
            //int b1;
            PrintB(ref b1);
            Console.WriteLine(b1);

            //
            //int b2 = 10;     // in out parameter not mandatory to assign value in calling method
            int b2;
            PrintC(out b2);
            Console.WriteLine(b2);

            //
            int a = 10, b = 5 , add , sub, mul , div;
            PrintD(a, b, out add, out sub, out mul, out div);
            Console.WriteLine($"{a} + {b} = {add}");
            Console.WriteLine($"{a} - {b} = {sub}");
            Console.WriteLine($"{a} * {b} = {mul}");
            Console.WriteLine($"{a} / {b} = {div}");

            //
            PrintE(10, 20, 30, 40);    // using params
            PrintE();             // (null) = no error due to params

            string name = "Pranav Yadav";
            // name.Split(new char[] { " " });
            name.Split(' ');    // using params



            Console.ReadLine();
        }

        static void PrintA(int a) // called method
        {
            a = 100;
        }

        static void PrintB(ref int a)
        {
            a = 100;   // no error  not mandetory to assign value
        }

        static void PrintC(out int a)
        {
           //  a = 1000;  // it is mandetory to assign value
             a = 1000;
        }
        // out keyword is useful when we want to return more than one value from method

        static void PrintD(int a, int b, out int add, out int sub, out int mul, out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }


        // params keywords... to use for give direct arrey value without new int [] {...}

        static void PrintE(params int[] numbers)    // put params at in last when using muiltiple parameters
        {
            if (numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"sum of arrey : {sum}");
            }
            else
            {  
             Console.WriteLine($"EMPTY ARREY");
            }
        }
    }
}
