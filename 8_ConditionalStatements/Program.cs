using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _8_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please enter the first number");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter the second number");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter the third number");
            //int third = int.Parse(Console.ReadLine());

            //Console.WriteLine($"You entered : {first} {second} {third}");

            // conditional statements example

            #region nested if else

            //if (first > second)
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"first {first} is gretter number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"third {third} is gretter number");
            //    }
            //}
            //else if (second > first)
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine($"second {second} is gretter number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"third {third} is gretter number");
            //    }
            //}
            //else 
            //{
            //    if (first > third) 
            //    {
            //        Console.WriteLine($"first {first} and second {second} is gretter number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"third {third} is gretter number");
            //    }
            //}

            #endregion nested if else

            // use ? :  for if else

            #region nested ternary operator

            //int no = (first > second) ?
            //    ((first > third) ? first : third) :
            //    ((second > third) ? second : third);

            //Console.WriteLine($"{no} is gretter number");

            #endregion nested ternary operator

            #region divisible 3&5 

            // if no is divisible by 3 = three
            // if no is divisible by 5 = five
            // if no is divisible by 3 & 5 = three & five

            //Csole.WriteLine("please enter a number");
            //int no = int.Parse(Console.ReadLine());

            //if (no % 3 == 0 && no % 5 == 0)
            //    Console.WriteLine($"three and five");

            //else if (no % 3 == 0)
            //    Console.WriteLine($"three");

            //else if (no % 5 == 0)
            //    Console.WriteLine($"five");

            #endregion divisible 3&5 

            #region even and odd number

            //Console.WriteLine("please enter a number");
            //int no = int.Parse(Console.ReadLine());

            //string result = ( no % 2 == 0 ) ? "Even" : "Odd";
            //Console.WriteLine(result);

            #endregion even and odd number

            #region grade meaning

            Console.WriteLine("please enter a grade");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine($"DISTINCTION");
                    break;
                case 'B':
                    Console.WriteLine($"first class");
                    break;
                case 'C':
                    Console.WriteLine($"second class");
                    break;
                case 'D':
                    Console.WriteLine($"Third class");
                    break;
                case 'F':
                    Console.WriteLine($"fail");
                    break;

                default:
                    Console.WriteLine("no grade");
                    break;
            }

        #endregion grade meaning

            Console.ReadLine();
        }
    }
}
