using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Rollnumber = 1;
            s.Name = "Pranav";
            s.Gender = Gender.Male;
            s.Subject = Subject.Sanscrit;

            //Console.WriteLine($"Rollnumber: {s.Rollnumber}, Name: {s.Name}, Gender: {GetGender(s.Gender)}");
            Console.WriteLine($"Rollnumber: {s.Rollnumber}, Name: {s.Name}, " +
                $"Gender: {s.Gender}, Subject: {s.Subject}");


            Student s1 = new Student();
            s1.Rollnumber = 11;
            s1.Name = "Ashu";
            s1.Gender = Gender.Male;
            s1.Subject = Subject.English;

            Console.WriteLine($"Rollnumber: {s1.Rollnumber}, Name: {s1.Name}, Gender: {s1.Gender}");

            Student s2 = new Student();
            s2.Rollnumber = 09;
            s2.Name = "Seeta";
            s2.Gender = Gender.Male;
            s2.Subject = Subject.Marathi;

            Console.WriteLine($"Rollnumber: {s2.Rollnumber}, Name: {s2.Name}, Gender: {s2.Gender}");

            //   //
            Console.WriteLine("All Item From Enum");

            string[] names= Enum.GetNames(typeof(Gender));

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();    // just for new line

            Console.WriteLine("All Value From Enum List");

            int[] values = (int[]) Enum.GetValues(typeof(Gender));  

            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine();    // just for new line


            Console.ReadLine();
        }
        static string GetGender(int Gender)
        {
            switch (Gender)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "INVALID GENDER";
            }
        }
    }
}
