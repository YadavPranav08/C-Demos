using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ICustomer i1 = new ICustomer();  // can not create object of abstract and interface class

            //ICustomerp1 i1 = new SilverCustomer();
            //i1.Showstiming();
            //i1.PrintTicket();

            //i1 = new GoldCustomer();
            //i1.Showstiming();
            //i1.PrintTicket();

            //SilverCustomer s1 = new SilverCustomer();
            //s1.Showstiming();
            //s1.PrintTicket();

            //ICustomerp1[] Customers = new ICustomerp1[2];
            //Customers[0] = new SilverCustomer();
            //Customers[1] = new GoldCustomer();

            //for(int i = 0; i < Customers.Length; i++)
            //{
            //    Customers[i].Showstiming();
            //    Customers[i].PrintTicket();
            //}

            A a1 = new A();
            a1.PrintA();
            a1.PrintB();
            //a1.Print();
            ((IA)a1).Print();
            ((IB)a1).Print();

            IA a2 = new A();
            a2.PrintA();
            //a2.PrintB();
            a2.Print();

            IB b1 = new A();
            b1.PrintB();
            //b1.PrintA();
            b1.Print();



            Console.ReadLine();
        }
    }
}
