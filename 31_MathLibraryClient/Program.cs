using _31_MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Calculator App");

            Calculator c1 = new Calculator();
            Console.WriteLine("Please enter a first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int second = int.Parse(Console.ReadLine());

            c1.Add(first, second);

            Console.WriteLine("ThankYou For Using Calculator App...!");



            Console.ReadLine();
        }
    }
}
