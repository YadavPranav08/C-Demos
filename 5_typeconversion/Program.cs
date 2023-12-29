using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _5_typeconversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine(i + j);
            
            // int>= string

            string a = i.ToString();  // int>= string  [changed]
            string b = j.ToString();
            Console.WriteLine(a + b);  //1010

            byte b1 = 10;   // string -> byte
            short s1 = b1;
            Console.WriteLine(s1);  //10

            float f1 = s1;
            Console.WriteLine(f1);  //10

            // convert float to int

            int i1 = (int)f1;    // float -> int
            Console.WriteLine(i1);

            float g1 = 10.50f;
            Console.WriteLine(g1);

            int i2 = (int)g1;
            Console.WriteLine(i2);

            // decimal to int conversion
            decimal d2 = 160.50m;
            int i3 = (int)d2;
            Console.WriteLine(i3);

            string s = "2000";
            int i4 = Convert.ToInt32(s);     // string -> int
            Console.WriteLine(i4);

            s = "true";    // convert to string to bool
            bool b4 = Convert.ToBoolean(s);
            Console.WriteLine(b4);

            // parse()
            s = "0805";
            i = int.Parse(s);   // string -> int
            Console.WriteLine(i);

           // s = "xyz";
            //i2 = int.Parse(s); 
           // Console.WriteLine(i2);  - not converted

            s = "xyz";
            int.TryParse(s, out i2);
            Console.WriteLine(i2);

            s = "true";
            int.TryParse(s, out i2);
            Console.WriteLine($"status : {i2}");

            s = "2222";
            b4 = int.TryParse(s, out i4);
            Console.WriteLine($"status : {b4} : result : {i4}");

            s = "xyz";
            b4 = int.TryParse(s, out i4);
            Console.WriteLine($"status : {b4} : result : {i4}");



            Console.ReadLine();
        }
    }
}
