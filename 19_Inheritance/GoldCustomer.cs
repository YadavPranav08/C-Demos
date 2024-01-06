using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    // child class / derived class
    internal class GoldCustomer : Customer    // Inheritance
    {
        //public int ticketamount;

        public GoldCustomer()
        {
            Console.WriteLine($"GoldCustomer() constructor called");
            ticketamount = 250;
        }

        //public void showstiming()
        //{
        //    Console.WriteLine($"***All Shows Timing***");
        //}

        //public void GetTicketAmount() 
        //{
        //    Console.WriteLine($"Gold Ticket Amount is {ticketamount}");
        //}

        public void PrintTicket()
        {
            Console.WriteLine($"Gold Ticket Printed");
        }


    }
}
