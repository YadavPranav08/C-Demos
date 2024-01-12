using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interface
{
    public interface ICustomer
    {
        void Showstiming();

       // void PrintTicket();  // in base interface if we add void method then this method ia add in all derived classes 

        // public int CustomerId;  // no field in interface
        //   public ICustomer ()   // no constructor in interface
        //   {
        //   } 
    }

    public interface ICustomerp1 : ICustomer
    {
        void PrintTicket();
    }
    

    //public class SilverCustomer : ICustomer, ICustomerp1
    public class SilverCustomer : ICustomerp1
    {
        public void PrintTicket()
        {
            Console.WriteLine("SilverCustomer PrintTicket() Method");
        }

        public void Showstiming()
        {
            Console.WriteLine("SilverCustomer Showstiming() Method");
        }


    }

    //public class GoldCustomer : ICustomer, ICustomerp1
    public class GoldCustomer : ICustomerp1
    {
        public void Showstiming()
        {
            Console.WriteLine("GoldCustomer Showstiming() Method");
        }

        public void PrintTicket()
        {
            Console.WriteLine("GoldCustomer PrintTicket() Method");
        }
    }


}
