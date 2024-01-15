using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _35_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student s1 = new student(); 
            //s1.rollnumber = 1;     // here assign/ write
            //s1.name = "Pranav";
            //s1.passmark = 35;
            //Console.WriteLine($"roll no.: {s1.rollnumber}, " +
            //    $"name: {s1.name}, passmarks: {s1.passmark}");  // here read

            //Student s1 = new Student();
            //s1.setrollnumber(1);     // here assign/ write
            //s1.setname("PRANAV");
            ////s1.setpassmark(99);
            //Console.WriteLine($"roll no.: {s1.Getrollnumber()}, " +
            //    $"name: {s1.Getname()}, passmarks: {s1.Getpassmark()}");  // here read

            //Student s2 = new Student();
            //s2.setrollnumber(-2);     // here assign/ write
            //s2.setname("ASHUTOSH");
            ////s2.setpassmark(30);
            //Console.WriteLine($"roll no.: {s2.Getrollnumber()}, " +
            //    $"name: {s2.Getname()}, passmarks: {s2.Getpassmark()}");

            // //after using property
            Student t = new Student();
            t.Rollnumber = 1;
            t.Name = "Shubham";
            Console.WriteLine($"Roll No.{t.Rollnumber}, Name: {t.Name}," +
                $"Passmark: {t.Passmark}");

            Student t1 = new Student();
            t1.Rollnumber = -1;
            t1.Name = "Yadav";
            Console.WriteLine($"Roll No.{t1.Rollnumber}, Name: {t1.Name}," +
                $" Passmark: {t1.Passmark}");


            Console.ReadLine();
        }
    }
    // // Abstraction & Evaluation:

    //public class Student
    //{
    //    private int rollnumber;
    //    private string name;
    //    private int passmark;

    //    public void setrollnumber ( int rollnumber )
    //    {
    //        if (rollnumber > 0)
    //        {
    //            this.rollnumber = rollnumber;
    //        }
    //        else
    //        {
    //            this.rollnumber = 00;
    //            Console.WriteLine("Negative rollnumer can not be received");
    //        }
    //    }

    //    public int Getrollnumber()
    //    {
    //       return rollnumber;
    //    }

    //    public void setname(string name)
    //    {
    //        this.name = name;  
    //    }

    //    public string Getname()
    //    {
    //        return string.IsNullOrEmpty(name) ? "Name not provided" : name;
    //    }

    //    // // this is my try // ...passmark can not have setter method this can only have a getter method
    //    //public void setpassmark(int passmark)
    //    //{
    //    //    //this.passmark = passmark;
    //    //    if (passmark < 35)
    //    //    {
    //    //        Console.WriteLine($"FAIL SGTUDENT: {passmark} < 35");
    //    //    }
    //    //    else
    //    //    {
    //    //        Console.WriteLine($"PASSED STUDENT");
    //    //    }
    //    //}

    //    public int Getpassmark()
    //    {
    //        return this.passmark;
    //    }

    //}

    // // property:
    public class Student
    {
        private int rollnumber;
        private string name;
        private int passmark = 35;

        public int Rollnumber
        {
            get
            {
                return this.rollnumber;
            }
            set
            {
                if (value > 0)
                {
                    this.rollnumber = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(name) ? name : "NO Name";
            }
            set
            {
                this.name = value;
            }
        }

        public int Passmark
        {
            get 
            { return this.passmark; }
        }

        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string email { get; set; }     // for future use we use get set  // auto implimented property
                                              // same as city likh dega itana nahi likhana padega
     }
}
