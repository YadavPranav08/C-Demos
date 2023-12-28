using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10; int j = 10;
            Console.WriteLine(i);

            i = 20;
            Console.WriteLine(i); // 20

            int a = i + j;
            Console.WriteLine(a); // 30

            int b = i - j;
            Console.WriteLine(b); // 10

            int c = i * j;
            Console.WriteLine(c); // 200

            int d = i / j;         //2
            Console.WriteLine(d);

            int e = i % j;
            Console.WriteLine(e); // 0

            int pr = 5 % 2;
            Console.WriteLine(pr); // 1

            // i = i+1  = i++

            i++;
            Console.WriteLine(i); //21

            i++;
            Console.WriteLine(i); // 21 post increment

            ++i; 
            Console.WriteLine(i); //23 pre increment

            //i= i+5  -- 28  = compound operator

            i += 5;
            Console.WriteLine(i); //28

            i -= 8;
            Console.WriteLine(i); //20

            i *= 2;
            Console.WriteLine(i); // 40

            i /= 2;
            Console.WriteLine(i); // 20

            // comparison i= 20 & j= 10

            bool result = i == j;
            Console.WriteLine(result);// false

            result = i != j;
            Console.WriteLine(result);//true

            result = i < j;
            Console.WriteLine(result); // false

            result = i >= j;
            Console.WriteLine(result); // true

            result = i > j;
            Console.WriteLine(result); // true

            i -= 10;
            Console.WriteLine(i); // 10

            result= i>j; 
            Console.WriteLine(result); // false

            result = i >= j; 
            Console.WriteLine(result); // true

            result = i >= j &&i < j;
            Console.WriteLine(result);  // false

            result = i < j || i > j;
            Console.WriteLine(result);  // false

            result = i >= j && i <= j;
            Console.WriteLine(result);  // true





            Console.ReadLine();
        }
    }
}
