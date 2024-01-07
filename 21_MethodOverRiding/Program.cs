using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Pranav", "Yadav");
            c1.Print(); 

            //SilverCustomer s1 = new SilverCustomer("abc" , "xyz");
            //s1.Print();

            //Customer c2 = new SilverCustomer("def", "uvw");
            //c2.Print();

            //Customer c3 = new SilverCustomer("def", "uvw");
            //((SilverCustomer)c3).Print();

            Customer c4 = new GoldCustomer("pratu" , "yadav");
            c4.Print();

            // write arrey of this class
            // like that: 
            //int[] numbers = new int[] {10,20,30};

            Customer[] customers = new Customer[]
            {
             new Customer("Pranav" , "Yadav"),
             new SilverCustomer ("Sandip" , "Popat", "Pawar"),
             new GoldCustomer("abc" , "xyz"),
             new Advancesilvercustomer("pqr", "rpq" ,"mnp"),
            };

            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].Print();
            }



            Console.ReadLine();
        }
    }

    // class
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;

         
        public Customer(string fn, string ln)   // constructor
        {
            FirstName = fn;
            LastName = ln;
        }

        public virtual void Print()          // virtual/ override/ abstract
        {
            Console.WriteLine($"{FirstName} {LastName}: Normal Customer");
        }

    }

    //new class1
    public class SilverCustomer : Customer
    {
        public SilverCustomer(string fn, string mn, string ln) : base(fn, ln)

        {
           
            MiddleName = mn;
           
        }

        // if we need to output object wise(like) then OVERRIDE keyword are require to use
        // but that time we need to make VIRTUAL keyword in base field
        public override void Print()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName} : Silver Customer");
        }

    }

    // new class2

    public class GoldCustomer : Customer
    {
        public GoldCustomer(string fn, string ln) : base(fn, ln)
        {
           
        }
        public override void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}: Gold Customer");
        }
    }

    // new class 3

    public class Advancesilvercustomer : SilverCustomer
    {
        public Advancesilvercustomer(string fn, string mn, string ln) : base(fn, mn, ln) { }

        public override void Print()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}: Advance Silver Customer");
        }

    }

}

