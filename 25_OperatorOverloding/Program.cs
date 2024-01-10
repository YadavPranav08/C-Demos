using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _25_OperatorOverloding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int type with == operator
            //int i = 10;
            //int j = i;  // AND int j = 10
            //if(i == j)
            //{
            //    Console.WriteLine("i and j are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("i and j are NOT EQUAL");
            //}
            #endregion int type with == operator

            #region string type with == operator

            //string s = "Pranav";
            //string t = "Pranav";   // string t = s;
            //if (s == t)    
            //{
            //    Console.WriteLine("s and t are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("s and t are NOT Equal");
            //}

            #endregion string type with == operator

            #region student type with == operator

            //student s1 = new student(1, "Pranav", "Yadav");
            ////student s2 = s1;           // when object are same then resuly is ok 
            //student s2 = new student(1, "Pranav", "Yadav"); // but with new object it not see referance then we need to write operator overloding

            //if (s1 == s2)
            //{
            //    Console.WriteLine("s1 and s2 are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("s1 and s2 are NOT EQUAL");
            //}

            #endregion student type with == operator

            #region example

            student s1 = new student(1, "Pranav", "Yadav");
            student s2 = new student(2, "Ashutosh", "Pawar");
            student s3 = s1 + s2;
            Console.WriteLine($"{s3.Rollnumber} {s3.Firstname} {s3.Lastname}");



            #endregion example


            Console.ReadLine();
        }
    }

    public class student
    {
        public int Rollnumber;
        public string Firstname;
        public string Lastname;

        public student(int rn, string fn, string ln)
        {
            Rollnumber = rn;
            Firstname = fn;
            Lastname = ln;
        }

        // opertor overloding

        public static bool operator == (student s1 , student s2)
        {
            return s1.Rollnumber == s2.Rollnumber &&
                s1.Firstname == s2.Firstname &&
                s1.Lastname == s2.Lastname;

        }

        public static bool operator !=(student s1, student s2)
        {
            return s1.Rollnumber != s2.Rollnumber &&
                s1.Firstname != s2.Firstname &&
                s1.Lastname != s2.Lastname;

        }

        // example

        public static student operator +(student s1, student s2)
        {
            int rn = s1.Rollnumber + s2.Rollnumber;
            string fn = s1.Firstname + "," + s2.Firstname;
            string ln = s1.Lastname + "," + s2.Lastname;

            return new student (rn, fn, ln);

        }

    }

}
