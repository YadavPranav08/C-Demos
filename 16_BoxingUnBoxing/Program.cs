using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine($"i = {i}");
            object o = i;
            Console.WriteLine($"o = {o}");  // int=> object / value type => referance type == boxing

            int j = (int) o;
            Console.WriteLine($"j = {j}"); // object=> int / referance type => value type == unboxing

            // j = i;

            // object is a base type for all type of dot net

            object o1 = 10;
            o1 = "$";
            o1 = "abc";
            o1 = 3.14f;
            o1 = true;
            


            Console.ReadLine();
        }
    }
}
