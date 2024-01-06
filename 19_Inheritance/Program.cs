using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SilverCustomer s1 = new SilverCustomer();
            //s1.showstiming();
            //s1.Getticketamount();
            //s1.PrintTicket();

            //GoldCustomer g1 = new GoldCustomer();
            //g1.showstiming();
            //g1.Getticketamount();
            //g1.PrintTicket();

            //PlatinumCustomer p1 = new PlatinumCustomer();
            //p1.showstiming();
            //p1.Getticketamount();
            //p1.PrintTicket();

            //Customer c1 = new Customer();
            // c1 is a referance variable of type customer pointing customer type

            //Customer c2 = new SilverCustomer();
            // c2 is a referance variable of type customer pointing silvercustomer type

            //SilverCustomer s2 = new Customer();   // compiler error
            // //SilverCustomer s2 = (SilverCustomer)new Customer();  // runtime error


            // Customer c10 = new Customer();

            //Customer c11 = new SilverCustomer();

            SilverCustomer s11 = new SilverCustomer("Shri Ganesh");

            // if we give parametetr to both parameter and child field 
            // so we need to give {constructor chain} (:base(name)) keyword to child field
            // but when it run they firstly pass object to parent field and then 
            // pass by child field and it output is 1st= parent 2nd= child



            Console.ReadLine();
        }
    }
}
