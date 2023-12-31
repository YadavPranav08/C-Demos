using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9_LoopingStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While loop
            //int start = 1;    // [initialization]
            //while (start <= 15)  // [condition]
            //{
            //    Console.WriteLine(start);
            //    start++;    // [updation]
            //}

            #endregion while loop

            #region do while loop

            //int start = 1;
            //do
            //{
            //    Console.WriteLine($"{start} RAM KRISHNA HARI");
            //    start++;
            //} while (start <= 1000);

            #endregion do while loop

            #region for loop

            //for (int start = 1; start <= 10; start++) 
            //{
            //    Console.WriteLine(start);
            //}


            #endregion for loop

            #region for loop senario

            // example of break statement

            // for (int start = 1; start <= 10; start++)
            //{ if (start == 6)
            //    {
            //       // break;     //  5 ke baad stop
            //        continue;  //  sirf 5 nahi aayega
            //       }

            // without break statement

            //{ Console.WriteLine(start);
            //    if (start == 5)
            //    {
            //        start = 10;
            //    }
            //}


            //practice for diwali rangoli




            //for (int i = 6; i > 0; i--)
            //    {
            //    for (int j = 1; j <= i; j++)
            //      {
            //        Console.Write($"{i}\t");
            //      }
            //        Console.WriteLine();
            //    }

            #endregion for loop senario


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($" {i} ");
            //    //break;
            //    continue;
            //}


            //int i = 1;
            //for (; i <= 10;)
            //{
            //    Console.Write($" {i} ");
            //    i++;
            //}


            //for (int i = 1; i <= 10; i++) 
            //{
            //    if (i == 5 )
            //    {
            //        //break;
            //        continue;
            //    }
            //    Console.Write($" {i} ");

            //}



             for (int i =1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                if (i == 10)
                {
                    break;
                }
                Console.Write($" {i} ");
            }




            Console.ReadLine();
        }
    }
}
