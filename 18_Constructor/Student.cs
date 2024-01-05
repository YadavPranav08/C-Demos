using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructor
{
    public class Student
    {
        public int rollnumber;
        public string firstname;
        public string lastname;
        public static string coursename;


        // create constructor
        //default constructor / parameterless constructor
        public Student()
        {
            Console.WriteLine($"Student() constructor called");
            //coursename = "dotnet";
        }

        // parameterized constructor
        public Student(int rn, string fn, string ln)
        {
            Console.WriteLine($"Student(int rn, string fn, string ln) constructor called");
            rollnumber = rn;
            firstname = fn;
            lastname = ln;
        }

        // copy Constructor
        public Student(Student s)
        { 
            this.rollnumber = s.rollnumber;
            this.firstname = s.firstname;
            this.lastname = s.lastname;
        }

        // static constructor
        static Student()
        {
            Console.WriteLine($"Static Student() constructor called");
            coursename = "DotNet";
        }



        public void Details()
        {
            Console.WriteLine($"rollnumber: {rollnumber}, name: {firstname}, surname: {lastname}, coursename: {coursename} ");
        }

        public void Initializer (int rn, string fn, string ln) 
        {
            rollnumber = rn;
            firstname = fn;
            lastname = ln;
        }

    }
}
