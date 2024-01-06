using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    // parent class / base class
    public class Customer
    {
        public int ticketamount;    // field
        public string name = "customer";

        public Customer()
        {
            Console.WriteLine($"Customer() constructor called");
        }

        public Customer(string n) 
        { 
         Console.WriteLine($"Inside Customer (string n): {n} ");
        }

        public void showstiming()
        {
            //Console.WriteLine($"** All Todays Show **");
            Console.WriteLine($"**No Show Todays**");

        }

        public void Getticketamount()
        {
            Console.WriteLine($"silver ticket amount is {ticketamount}");

        }


    }

}
