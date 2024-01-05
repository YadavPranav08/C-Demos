using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_ClassObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;  // i is a variable of type int
            //student s0;  // i is a variable of type student

            student s1 = new student();
            s1.rollnumber = 1;
            s1.Name = "Pranav";
            s1.City = "Pune";
            s1.Print();

            student s2 = new student(); 
            s2.Create(2, "Shubham", "Mumbai");
            s2.Print();

            student.coursename = "Csharp";  // wer can change value of static field

            student s3 = new student();
            s3.Create(3, "suresh", "Ppur");
            s3.Print(); 

            student s4 = new student();
            s4.Create(4, "pavin", "mohol");
            s4.Print();

            // 
            //world w1 = new world();   // eroor due to creating object of static class
            
            Console.WriteLine($"Numberofcountries: {world.Numberofcountries}");
            Console.WriteLine($"Numberofcontinents: {world.Numberofcontinents}");



            Console.ReadLine();
        }
    }

    class student
    {
        public int rollnumber;
        public string Name;
        public string City;
        public static string coursename= "DOT NET";

        public void Print()
        {
            Console.WriteLine($"rollnumber: {rollnumber} name: {Name} city: {City} coursename: {coursename}");
           // PrintA();   //instance can calling to static method
        }
        

        public void Create(int rn, string name, string city) 
        {
            rollnumber = rn;
            Name = name;
            City = city;

            //this keyword points current instance at that class
            // this keyword is use only in instance class... not for static
            this.rollnumber = rn;
            this.Name = name;
            this.City = city;
        }

        public static void PrintA()
            // instance method can calling to static method
            // but static can calling only static method...
        {
            Console.WriteLine($"static PrintA() called");
           
            //Console.WriteLine($"rollnumber: {rollnumber} name: {name} city: {city} coursename: {coursename}");
            //static example... // static  can not calling instance method


            // to access instance member in static method 
            // we need to create object

            //student s = new student();
            //s.Create(5, "kumar", "Pune");
        }
    }
    static class world
    {
        public static int Numberofcountries = 293;    // { get; set; }
        public static int Numberofcontinents = 8;     // { get; set; }
    }
    // if we remove static keyword then error are coming due to 
    // static class can have only static member


    

}
