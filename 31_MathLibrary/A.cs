using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibrary
{
    public class A
    {
        //private void PrintA()        //   accessible only within same type 
        //protected void PrintA()      // 	accessible within same type as well as in derived type
        // 	accessible from another assembly from derived type

        //public void PrintA()         // 	anywhere in application
        // 	anywhere in same assembly as well as in another assembly

        //internal void PrintA()         // 	anywhere within same assembly / project

        protected internal void PrintA()

        {
            Console.WriteLine("PrintA()");
        }

        void Print()
        {
            PrintA();
        }

        
    }

    public class B : A
    {
        private void PrintB()
        {
            A a = new A();
            // A.PrintA();       // No Accessibility when Private
            // base.PrintA();    // No Accessibility

            base.PrintA();     // Accessible when protected


            Console.WriteLine("PrintB()");
        }
    }

    public class C
    {
        private void PrintC()
        {
            A a = new A();
            a.PrintA();

            Console.WriteLine("PrintC()");
        }
    }
}

