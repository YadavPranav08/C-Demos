using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student()
            { name= "Geetanjali"};
            s.AddEnquiry();

            Console.ReadLine();
        }
    }
}
