using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_IsAsKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new SilverCustomer();
            c1.Print();

            Customer c2 = new GoldCustomer();
            c2.Print();

            SilverCustomer c3 = (SilverCustomer)c1;
            c3.Print();

            //GoldCustomer c4 = (GoldCustomer)c1;
            //c4.Print();

            //bool b1 = c1  is GoldCustomer;     //.. is Keyword to use for check it is possible or not
            //Console.WriteLine(b1);
            //if (b1)
            //{
            //    GoldCustomer c4 = (GoldCustomer)c1;
            //    c4.Print();
            //}

            GoldCustomer c4 = c1 as GoldCustomer;
            if (c4 != null) 
            { 
              c4.Print();
            }


            Console.ReadLine();
        }
    }
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class SilverCustomer : Customer
    {
        public override void Print() 
        {
            Console.WriteLine("SilverCustomer Print() Method Called");
        }
    }
    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GoldCustomer Print() Method Called");
        }
    }
}
