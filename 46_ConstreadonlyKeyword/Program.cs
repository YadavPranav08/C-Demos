using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _46_ConstreadonlyKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Rollnumber = 1;
            s1.Name = "Mrunal";
            //s1.CompanyName = "Microsoft";
            Console.WriteLine($"Rollnumber: {s1.Rollnumber} Name: {s1.Name} " +
                //$"Company_Name: {Student.CompanyName}");
                $"Company_Name: {s1.CompanyName}");       //.. By readonly Keyword ..//

            //Student.CompanyName = "TCS";

            Student s2 = new Student();
            s2.Rollnumber = 2;
            s2.Name = "Krunal";
            //s2.CompanyName = "Microsoft";
            Console.WriteLine($"Rollnumber: {s2.Rollnumber} Name: {s2.Name} " +
                //$"Company_Name: {Student.CompanyName}");
               $"Company_Name: {s2.CompanyName}");


            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Rollnumber { get; set; }
        public string Name { get; set; }

        //public static string CompanyName = "Microsoft";

        //public const string CompanyName = "TCS";

        public readonly string CompanyName = "TCS";

        //public static readonly string CompanyName = "TCS";

        public Student()
        {
            // Runtime
            CompanyName = "V#";
        }

    }
}
