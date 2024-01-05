using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.rollnumber = 01;
            //s1.firstname = "Tivendrakumar";
            //s1.lastname = "Nishad";
            //s1.Details();

            //Student s2 = new Student(); 
            //s2.Details();

            //// object initializer syntax
            //Student s3 = new Student()
            //{ 
            // rollnumber = 02,
            // firstname = "srujal",
            // lastname = "pokale",
            //};
            //s3.Details();

            ////
            //Student s4 = new Student();
            //s4.Initializer(03, "lubana", "tamboli");
            //s4.Details();

            //s4.Initializer(04, "rutuja", "bhosale");
            //s4.Details();

            //Student s5 = new Student(05,"Prathamesh", "Aoutade");
            //s5.Details();

            ////
            //Student s6 = new Student();
            //Student s7 = new Student(07, "abc", "xyz");

            //Student s8 = new Student(08, "abcd", "zzzz");
            //s8.Details();

            // i need to write s8 details in s9 
            // so we have two way to wright

            //Student s9 = s8;   // s9 & s8 will point same object in heap
            //s9.Details();

            //Student s10 = new Student();
            //s10.rollnumber = s8.rollnumber;
            //s10.firstname = s8.firstname;
            //s10.lastname = s8.lastname;
            //s10.Details();

            //Student s11 = new Student(s10);  // from copy constructor
            //s11.Details();

            //Student s12 = new Student();  // first call static member then call instance member
            ////s12.Details();\
            //Student s13 = new Student();

            Console.WriteLine($"course name: {Student.coursename}");

            //Customer c1 = new Customer();  // we will not able to create object when private constructor are use



            Console.ReadLine();
        }
    }
}
