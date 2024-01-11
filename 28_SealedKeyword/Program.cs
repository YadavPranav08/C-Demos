using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SealedKeyword
{
    // sealed keyword is only used when ovreride keyword are used
    // and used for that class if forword classes not neeed to override
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();

            Customer c2 = new SilverCustomer();
            c2.Print();

            Customer c3 = new AdvancedSilverCustomer();
            c3.Print();


            Console.ReadLine();
        }
    }

    //public sealed class Customer
    public class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Print() Customer Called");
        }
        
    }

    public class SilverCustomer : Customer
    {
        public sealed override void Print()
        {
            Console.WriteLine ("Print() SilverCustomer Called");
        }
    }

    public class AdvancedSilverCustomer : SilverCustomer
    {
        // // we can not override after sealed class print 
        //public override void Print()
        //{
        //    Console.WriteLine("Print() AdvanceSilverCustomer Called");
        //}

        public new void Print()
        {
            Console.WriteLine("Print() AdvanceSilverCustomer Called");
        }

        //public class student { }  // normal class
        //public static class student { } // static class
        //public abstract class student { } // abstract class
        //public static abstract class student{} // not applied 
        //public sealed class student { } // sealed class
        //public static sealed class student { } // not applied
    }


}
