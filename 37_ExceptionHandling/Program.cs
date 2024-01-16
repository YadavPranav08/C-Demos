using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Calculator App");
                Console.WriteLine("Please enter a numerator");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a denomarator");
                int den = int.Parse(Console.ReadLine());

            
                Divide(num, den);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine($" Outer Catch Exception: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($" Outer Catch Exception: {ex.Message}");
            }

            Console.WriteLine("THANK YOU...!");

            Console.ReadLine();             
        }

        static void Divide(int num, int den)
        {
            //try
            //{
            try
            {
                int div = num / den;
                Console.WriteLine($"Divide = {num} / {den} = {div}");
            }
            //catch
            //{
            //    Console.WriteLine("Denominator Can Not Be Zero. Please enter Denominator greter than Zero");
            //}
            catch (Exception ex)
            {
                //Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);

                File.WriteAllText(@"logs\Error.txt", $"{ex.Message} \n");
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($" Outer Catch Exception: { ex.Message}");
            //}

            finally
            {
                Console.WriteLine("Devide Operation Completed");
            }
        }
    }

}
