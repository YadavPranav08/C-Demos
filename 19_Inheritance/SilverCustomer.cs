using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class SilverCustomer : Customer    // Inheritance
    {
       public string name = "Silver customer";

        // // child class / derived class

        // public int ticketamount;    // field

        //public SilverCustomer()     // constructor
        //{
        //    Console.WriteLine($"SilverCustomer() constructor called");
        //    Console.WriteLine($"name from current: {name}");
        //    Console.WriteLine($"name from customer: {base.name}");

        //    ticketamount = 150;
        //}

        //
        // consructor chain 
        public SilverCustomer(string name) : base(name)
        {
            Console.WriteLine($"Inside Silver Customer SilverCustomer(): {name} ");
        }



        //public void showstiming()
        //{
        //  Console.WriteLine($"** All Todays Show **");
        //}

        //public void Getticketamount() 
        //{
        // Console.WriteLine($"silver ticket amount is {ticketamount}");

        //}

        public void PrintTicket()
        { 
         Console.WriteLine($"Ticket printed");
        }
       

    }
}
