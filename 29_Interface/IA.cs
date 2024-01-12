using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    public interface IA
    {
        void PrintA();

        void Print();
    }

    public interface IB 
    {
        void PrintB();

        void Print();
    }

    public class B { }

    public class A : B, IA, IB // : B    // if we need to Inherance muiltiple class and interface that time first Inherance class and then interfaces if not then get compiler error
    {
        // // Try to impliment interface explicitely

        //public void Print()
        //{
        //    Console.WriteLine("Print() Method Called");
        //} 

        void IA.Print()   // if we write explicitely then this method get automatically public so dont need to write public
        {
            Console.WriteLine("IA: Print() Method Called");
        }

        void IB.Print()   // if we write explicitely then this method get automatically public so dont need to write public
        {
            Console.WriteLine("IB: Print() Method Called");
        }

        public void PrintA()
        {
            Console.WriteLine("A: PrintA() Method ");
        }
        public void PrintB()
        {
            Console.WriteLine("B: PrintB() Method ");
        }
    }


}
