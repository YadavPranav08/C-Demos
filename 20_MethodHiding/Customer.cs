using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    public class Customer
    {
        public void Print()
        {
            Console.WriteLine("Customer print() method Called");
        }

        public void PrintA()
        {
            Console.WriteLine("Customer printA() method Called");
        }

    }

    // new child class
    public class SilverCustomer : Customer
    {
        //new keyword to use methodhiding in Inheritance
        new public void Print()
        {
            Console.WriteLine("SilverCustomer print() method called");
        }

        public void PrintB()
        {
            Console.WriteLine("SilverCustomer printB() method Called");
        }


    }



}


