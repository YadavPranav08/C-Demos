using System;    // to import namespace
using Cinema;
using Bank;
using ab = Cinema.Abhiruchi;    // give alias as namespace (name) is big
using _30_NamespaceDemo.BankAccount;    

class program
{
    /*even if we are not writing namespace, then default namespace 
     (global namespace) will be there with the same name as assembly 
    name(or project name) */

    static void Main()
    {
        Convert.ToInt32(10);

        //System.Console.WriteLine("Hello Guys");
         Console.WriteLine("Hello Guys");

        //
        //Cinema.SilverCustomer sc = new Cinema.SilverCustomer();
        //sc.Details();

        SilverCustomer sc = new SilverCustomer();     // using Cinema;
        sc.Details();

        //Bank.SavingCustomer sc2 = new Bank.SavingCustomer();
        //sc2.Details();

        SavingCustomer sc2 = new SavingCustomer();
        sc2.Details();

        //Cinema.Customer c1 = new Cinema.Customer();
        //Cinema.Abhiruchi.Customer c1 = new Cinema.Abhiruchi.Customer();
        Customer c1 = new Customer();     // by default take from bank
        ab.Customer c2 = new ab.Customer();  // now its take from Cinema
        
        //

        Account a1 = new Account();    // automatically add namespaces
        a1.Details();                 


        Console.ReadLine();
    }
}

// power of namespce
namespace Cinema
{
    namespace Abhiruchi
    {
        class Customer { }

    }

    public class SilverCustomer
    {
        public void Details()
        {
            Console.WriteLine("SilverCustomer");
        }
    }
}

namespace Bank
{
    class Customer { }


    public class SavingCustomer
    {
        public void Details()
        {
            Console.WriteLine("SavingCustomer");
        }
    }
}