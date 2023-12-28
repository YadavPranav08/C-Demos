using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true; 
            bool b2 = false;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(sizeof(bool));
            
            // for to wait
            /* readline = to wait for run
                 and show code */
            byte A1 = 20;
            Console.WriteLine(A1);
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            

            short i1 = 1000 ;
            Console.WriteLine($"{i1} : {sizeof(short)} : {short.MinValue}: {short.MaxValue}");

            int i2 = 100;
            Console.WriteLine($"{i2} : {sizeof(int)} : {int.MinValue}: {int.MaxValue}");

            long i3 = 100000;
            Console.WriteLine($"{i3} : {sizeof(long)} : {long.MinValue}: {long.MaxValue}");


            float f1 = 10.5f;
            Console.WriteLine($"{f1} : {sizeof(float)} : {float.MinValue} : {float.MaxValue}");

            double f2 = 10.5;
            Console.WriteLine($"{f2} : {sizeof(double)}: {double.MinValue} : {double.MaxValue}");

            decimal d1 = 10.5m;
            Console.WriteLine($"{d1} : {sizeof(decimal)}: {decimal.MinValue} : {decimal.MaxValue}");

            char div = 'a';
            Console.WriteLine(div);
            Console.WriteLine(sizeof(char));

            string s1 = "pranav";
            Console.WriteLine(s1);
            // Console.WriteLine(sizeof(string)) = Error due to no limit for string

            Console.ReadLine();
            
        }
    }
}
