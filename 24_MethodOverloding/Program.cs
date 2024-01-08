using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodOverloding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            c1.Print();

            c1.Print(10);

            string ln = "kiva";
            c1.Print(out ln);

            int i = 10;
            c1.Print(ref i);

            c1.Print(10, 50);

           // c1.Print("Pranav");

            c1.Print(10, "Vishal");

            c1.Print("Vishal", 10);

            //calculator[] c2 = new calculator[] {};

            short s = 10;
            int i1 = 10;

            c1.Print(10);
            c1.Print(s);



            Console.ReadLine();
        }
    }

    public class calculator
    {
        public void Print()
        {
            Console.WriteLine("Print() Called");
        }

        public void Print(int num)
        {
            Console.WriteLine("Print(int num) Called");
        }

        public void Print(short num)
        {
            Console.WriteLine("Print(short num) Called");
        }


        // if we put ref and out at a time with same type then they give compiler error
        // but we give different different parameter with ref and out then it allow means int and string 
        public void Print(out string ln)
        {
            ln = "Yadav";
            Console.WriteLine("Print(out string ln) Called");
        }


        public void Print(ref int num)
        {
            Console.WriteLine("Print(ref int num) Called");
        }

        public void Print(int num1, int num2)
        {
            Console.WriteLine("Print(int num1, int num2) Called");
        }

        //public void Print(string name)
        //{
        //    Console.WriteLine("Print(string name) Called");
        //}

        public void Print(int num, string name)
        {
            Console.WriteLine("Print(int num, string name) Called");
        }

        public void Print(string name, int num)
        {
            Console.WriteLine("Print(string name, int num) Called");
        }

        public void PrintA(int[] num) 
        {
            Console.WriteLine("Print(int[] num) Called");
        }

        // this is not overloding
        //public void Print(params int[] num)
        //{
        //    Console.WriteLine("Print(int[] num) Called");
        //}




    }
}
