using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual(10, 20);
            //Console.WriteLine(b1);    // False

            //bool b2= c1.AreEqual(20, 20);
            //Console.WriteLine(b2);   // True

            //bool b3 = c1.AreEqual("abc", "xyz");
            //Console.WriteLine(b2);   // False

            //bool b4 = c1.AreEqual(10.5f, 4.5f);
            //Console.WriteLine(b4);   // True    //False

            //bool b5 = c1.AreEqual(50, "xyz");
            //Console.WriteLine(b5);   // False

            // // After Using Generic // //

            Calculator c1 = new Calculator();
            bool b1 = c1.AreEqual<int>(10, 10);
            Console.WriteLine(b1);

            bool b2 = c1.AreEqual<string>("abc", "xyz");
            Console.WriteLine(b2);

            bool b3 = c1.AreEqual<float>(20.5f, 20.5f);
            Console.WriteLine(b3);

            //

            // // dynamic for +
            c1.Add<float>(10.5f, 10.5f);

            c1.Add<int>(20, 1);

            c1.Add<string>("ABC", "xyz");

            // // Generic Class // 
            Student<int, string> s1 = new Student<int, string>();
            s1.Rollnumber = 1;
            s1.Name = "Praanav";
            string a = s1.Details();
            Console.WriteLine(a);

            Student<string, string> s2 = new Student<string, string>();
            s2.Rollnumber = "101";
            s2.Name = "Praanammm";
            string b = s2.Details();
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
