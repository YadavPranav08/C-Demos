using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _43_Delegates.Program;

namespace _43_Delegates
{
    internal class Program
    {
        public delegate void Printdelegate(string s);   // 1st gelegate declaration
        static void Main(string[] args)
        {
            //PrintA("Ganesh");

            //Printdelegate pd = new Printdelegate(PrintA);  // 2nd delegate instance
            Printdelegate pd10 = PrintA;               // shortcut
            pd10("God");    // 3rd delegate call

            Printdelegate pd1 = PrintA;
            Printdelegate pd2 = PrintB;
            Printdelegate pd3 = PrintC;

            Printdelegate pd = pd1 + pd2 + pd3 - pd2;

            pd("Vishal");

            Console.ReadLine();
        }
        static void PrintA(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void PrintB(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        static void PrintC(string name)
        {
            Console.WriteLine($"Good Morning {name}");
        }

        static string GetName()
        {
            return "Pranav";
        }

    }
}
