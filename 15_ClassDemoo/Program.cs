using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollnumber = 100;
            string name = "Panu";
            string city = "Pune";

            Console.WriteLine($"rollnumber {rollnumber}\n" +
                              $"name {name}\n" +
                              $"city {city}");


            // stack(student s1) & Hip(new student())
            student s1 = new student();

            s1.rollnumber = 1;
            s1.name = "Pranav";
            s1.city = "Shreepur";

            //Console.WriteLine($"rollnumber: {s1.rollnumber}, name: {s1.name}, city: {s1.city}");
            s1.Details();      // from void details

            student s2 = new student();

            s2.rollnumber = 2;
            s2.name = "Ishwari";
            s2.city = "Pune";

            //Console.WriteLine($"rollnumber: {s2.rollnumber}, name: {s2.name}, city: {s2.city}");
            s2.Details();      // from void details

            // circle class

            Circles c1 = new Circles();
            c1.Radius = 5;
            // c1.Pi = 3.14f;     // due to static keyword (value fix)
            c1.Area();

            Circles c2 = new Circles();
            c2.Radius = 15;
            // c2.Pi = 3.14f;
            c2.Area();

            c1.Radius = 10;
            c1.Area();

            Console.ReadLine();
        }
    }
    class student
    {
        // class field / data member
        public int rollnumber;
        public string name;
        public string city;


        // member function / method
        public void Details()
        {
            Console.WriteLine($"rollnumber: {rollnumber} name: {name} city: {city}");
        }
    }
}