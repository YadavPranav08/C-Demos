using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "pranav";
            Console.WriteLine(name);

            name = null;    // nullable
            Console.WriteLine(name);

            string namee = null;
            Console.WriteLine(namee);
               
            //int? age = null;
            //Console.WriteLine(age);


            // ? for to get null value 
            // ?? for to convert nullable value to non nullable value
            int? a = null;
            int b = a ?? 20;
            Console.WriteLine($"a : {a} : b : {b}");

            string email = "pranavsyadav08@gmail.com";
            string emailInUpper = email.ToUpper();
            Console.WriteLine($"email : {email} : email INUpper: {emailInUpper}");

            string nameei = "pranav";
            String nameeiinupper = nameei.ToUpper();
            Console.WriteLine($"name : {nameei}\nname in upper : {nameeiinupper}");

            // ?. for to prevent mull exception and run the code

            email = null;
            string emailinupperr = email?.ToUpper();
            Console.WriteLine($"email: {email} : email in upper : {emailinupperr}");   





            Console.ReadLine();
        }
    }
}
