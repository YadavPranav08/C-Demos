using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _38_ExceptionHandling_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome To Calculator App");
                Console.WriteLine("Please Enter A Numerator");
                int numerator, denominator;

                if (int.TryParse(Console.ReadLine(), out numerator))
                {
                    Console.WriteLine($"Please enter a Denominator");
                    if (int.TryParse(Console.ReadLine(), out denominator))
                    {
                        Divide(numerator, denominator);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid denominator");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid numerator");
                }
                Console.WriteLine("Thank You...! Visit Again...!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Main Methpod Catch Block :{ex.Message}");
            }

            Console.ReadLine();
        }
        static void Divide(int a, int b)
        {
            #region Using Conditional Check
            //if (b != 0)
            //{
            //    int div = a / b;
            //    Console.WriteLine($"Divide: {a} / {b} = {div}");
            //}
            //else
            //{
            //    Console.WriteLine("Denominator can not be zero");
            //}

            #endregion Using Conditional Check

            try
            {
        
               //if (b == 0)
               //{
               //     throw new Exception("Denominator is Zero");
               //}
                   int div = a / b;
                   Console.WriteLine($"Divide: {a} / {b} = {div}");
            }
            catch(Exception ex)
            {
                //Console.WriteLine($"Divide Catch Block : { ex.Message}");
                throw new Exception("Denominator is Zero");
            }


            Console.WriteLine("Division Operation Completed");
        }

    }
}
