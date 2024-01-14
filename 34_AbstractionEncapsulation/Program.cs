using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _34_AbstractionEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// you can insert new student data
            //student s1 = new student()
            //{ rollnumber = 01, name = "Ashutosh", gender = "male" };
            //s1.Insert();

            ////if (s1.IsValid())    // due to private
            ////{
            ////    s1.Insert();    // we can insert data
            ////}

            //student s2 = new student();
            //s2.Insert();

            student s10 = new student(10, "Ashu", "male");
            s10.Insert();

            

            Console.ReadLine();
        }
    }

    public class student
    {
        private int rollnumber;
        private string name;
        private string gender;

        public student(int rn, string fn, string g)
        {
            rollnumber = rn;
            name = fn;
            gender = g;
        }

        private bool IsValid()
        {
            if (rollnumber > 0 && !string.IsNullOrEmpty(name) && 
                !string.IsNullOrEmpty(gender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert()
        {
            if (IsValid())
            { 
                Console.WriteLine("New Student Insert() Successfully");
            }
            else
            {
                Console.WriteLine("INVALID DATA");
            }

        }

    }

}
