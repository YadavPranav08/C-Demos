using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MethodOverloding_Scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.PrintA();

            B b1 = new B();
            b1.PrintA();     // coming from class A
            b1.PrintA(10);  // Coming from class B

            Console.ReadLine();
        }
    }

    class A
    {
        public void PrintA()
        {
          Console.WriteLine("PrintA() Method Called" );
        }
        
    }

    class B : A
    {
        public void PrintA(int num)
        {
            Console.WriteLine("PrintA(int num) Method Called");
        }

    }
}
