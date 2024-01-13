using _31_MathLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibraryClient2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Client 2");

            Calculator c2 = new Calculator();
            c2.Add(01,06);
            Console.WriteLine("Thank You...! \n Visit Again...!");

            //Calculator c2 = new Calculator();
            c2.Add(2500, 2000);
            Console.WriteLine("Thank You...! \n Visit Again...!");


            Console.ReadLine();
        }
    }
}
