using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.PrintA();
            //c1.PrintB();

            SilverCustomer s1 = new SilverCustomer();
            s1.Print();
            c1.PrintA();
            s1.PrintB();

            Customer c2 = new SilverCustomer();
            c2.Print();
            c1.PrintA();
            //c2.PrintB
            ((SilverCustomer)c2).PrintB();


            //SilverCustomer s2 = (SilverCustomer)new Customer();
            //s2.Print();

            // A -> B -> C
            A a1 = new A();  a1.Print();
            B b1 = new B();  b1.Print();
            C c3 = new C();  c3.Print();

            A a2 = new B(); a2.Print();
            B b2 = new C(); b2.Print();
            A a3 = new C(); a3.Print();   


            Console.ReadLine();
        }
    }

    // muiltihybrid methodhiding

    class A 
    {
        public void Print()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        new public void Print()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        new public void Print()
        {
            Console.WriteLine("C");
        }
    }

}
