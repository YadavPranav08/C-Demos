using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MethodOverriding_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {                                 // new keyword , overide keyword
            A a1 = new A(); a1.Print();   // A,  A
            B b1 = new B(); b1.Print();   // B,  B
            C c1 = new C(); c1.Print();   // C,  C
            A a2 = new B(); a2.Print();   // A,  B
            A a3 = new C(); a3.Print();   // A,  A // B  // OVERHIDDEN METHOD
            B b2 = new C(); b2.Print();   // B,  B




            Console.ReadLine();
        }
    }

    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public new void Print()
        {
            Console.WriteLine("C");
        }
    }
}
    

