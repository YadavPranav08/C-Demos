using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_OptionalMethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 10; int b=10;
            Add(a, b);

            Add(10,20);    // give two value for two paramers

            sub(10);

            //Add();    // when both are default

            sum(b:10);   // named parameter

            add1(b: 10, c:15);  // named parameter a=0

            Console.ReadLine();
        }

        static void Add(int a, int b)   // there arew two parameter a & b
                                      
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        // if give default value then automaticaly take it  
        // for ex. Add(int a, int b = 5) so in main method we need only give one value
        static void sub(int a, int b=5)
        { 
         Console.WriteLine($"{a} - {b} = {a - b}");
        }

        // default value only at last

        static void sum([Optional] int a, int b)
        {
            Console.WriteLine($"sum of {a} + {b} = {a+b}");
        }
        // if optional at last then it is automatically assign for first
        // but first value optional then named parameter are required
        // optional will assign zero value

        static void add1([Optional] int a, int b, [Optional] int c)
        { 
         Console.WriteLine($"{a}+{b}+{c} = {a+b+c}"); 
        }
    }
}
