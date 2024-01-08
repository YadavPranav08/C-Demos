using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MuiltipleClassInheritance_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(); a1.Print();
            B b1 = new B(); b1.Print();
            A a2 = new B(); a2.Print();
            D d1 = new D(); d1.Print();
            

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

    public class D : B    // D:B:C (muiltiple class inheritance [not possible]) This is not possible in C# (Dimond Problem) // Due to Confusion(Ambugity)
    {
        //public void Print()
        //{
        //    Console.WriteLine("D");
        //}
    }
}
