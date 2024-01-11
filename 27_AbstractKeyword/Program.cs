using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SilverCustomer sc = new SilverCustomer();
            sc.Showstiming();
            sc.PrintTicket();

            GoldCustomer gc = new GoldCustomer();
            gc.Showstiming();
            gc.PrintTicket();

            PlatinumCustomer pc = new PlatinumCustomer();
            pc.Showstiming();
            pc.PrintTicket();

            // Customer c1 = new Customer();  // Compiler error due to base is abstract and in abstract base it does not have a method 
            // abstract class object creation not possible

            Customer c1 = new SilverCustomer();
            c1.PrintTicket();

            Customer c2 = new GoldCustomer(); 
            c2.PrintTicket();

            Customer c3 = new PlatinumCustomer();
            c3.PrintTicket();



            Console.ReadLine();
        }
    }

    public abstract class Customer
    {
        public Customer()
        {
            Console.WriteLine("Customer() Called");
        }

         public void Showstiming()
        {
            Console.WriteLine("**All Todays Shows**");
        }

        public abstract void PrintTicket();
    }

    public class SilverCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("SilverCustomer Ticket Printed");
        }
    }

    public class GoldCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("GoldCustomer Ticket Printed");
        }
    }

    public class PlatinumCustomer : Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("PlatinumCustomer Ticket Printed");
        }
    }


}
