using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArreyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region muiltiple even number
            //Console.WriteLine("Please enter a comma seperated number");
            //string input = Console.ReadLine();

            //string[] number = input.Split(',');

            //int Counter = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (int.Parse(number[i]) % 2 == 0)
            //    {
            //        Console.Write($"{number[i]} ");
            //        Counter++;
            //    }
            //}
            //Console.WriteLine($"\n {Counter}");
            #endregion muiltiple even number
            //
            #region even number till target number
            //Console.WriteLine("Please enter a Target  number");
            //int target = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= target; i++)
            //{ 
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}    
            //Console.WriteLine();   // new line
            #endregion even number till target number
            //

            // int number = new int [2];
            int[,] numbers = new int[3,3];       // [][] accept this way also

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"** ");
                    }
                    else
                    {
                        Console.Write($"{i}{j} ");
                    }
                }
                Console.WriteLine();  // new line

            }



            Console.ReadLine();
        }
    }
}
