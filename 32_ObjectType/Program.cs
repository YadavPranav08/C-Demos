using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Get Type Method   // it returns type information
            //int i = 10;
            //bool b = true;
            //string s = "Pranav";
            //student s1 = new student();

            //object i = 10;
            //Type i1 = typeof(int);
            //Type i2 = i.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //object b = true;
            //i1 = b.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //object s = "Pranav";
            //i1 = s.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");

            //object s1 = new student();
            //i1 = s1.GetType();
            //Console.WriteLine($"{i1.Namespace} : {i1.Name} : {i1.FullName}");
            #endregion Get Type Method  

            #region Tostring() Method  // reprent value in string format

            //int i= 10; int j= 10;
            //Console.WriteLine($"{i} + {j} = {i + j}");
            //Console.WriteLine(i.ToString() + j.ToString());

            //double d = 10.5;
            //Console.WriteLine(d.ToString());

            //student s = new student() {Firstname = "ASHUTOSH", Lastname = "PAWAR" };
            //Console.WriteLine(s.ToString());


            #endregion Tostring() Method

            #region Equal Method   // 	To check value equality we can override Equals() method

            //int i = 10; int j = i;
            //if (i == j)
            //{
            //    Console.WriteLine("i & j are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("i & J are NOT EQUAL");
            //}

            //student s1 = new student()
            //{ Firstname = "PRANAV", Lastname = "YADAV" };
            ////student s2 = s1;
            //student s2 = new student() 
            //{ Firstname = "PRANAV", Lastname = "YADAV" };

            //if (s1.Equals(s2))    // To check value equality we can override Equals() method
            ////if (s1 == s2)
            //{
            //    Console.WriteLine("s1 & s2 are EQUAL");
            //}
            //else
            //{
            //    Console.WriteLine("s1 & s2 are NOT EQUAL");
            //}


            #endregion Equal Method    

            #region GetHashCode() Method  // To maintain unique hash code for complex type object we need to override GetHashCode() method

            //int i = 25; int j = 25;
            //Console.WriteLine($"{i.GetHashCode()} {j.GetHashCode()}");

            //string s = "CHETAN";
            //string s1 = "more";
            //string s2 = "CHETAN";
            //Console.WriteLine($"{s.GetHashCode()} {s1.GetHashCode()} {s2.GetHashCode()}");

            //student sc1 = new student()
            //{Firstname = "Pranav", Lastname = "Yadav"};
            //student sc2 = new student()
            //{Firstname = "Pranav", Lastname = "Yadav"};

            //Console.WriteLine($"sc1: {sc1.GetHashCode()} sc2: {sc2.GetHashCode()}");


            #endregion GetHashCode() Method

            #region Compare Values

            //int i = 10, j = 10;
            student i = new student() { Firstname = "PRANAV", Lastname = "YADAV" };
            student j = new student() { Firstname = "PRANAV", Lastname = "YADAV" };

            string Result = (i == j) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(Result);

            Result = (i.Equals(j)) ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(Result);

            Result = (i.GetHashCode() == j.GetHashCode())  ? "EQUAL" : "NOT EQUAL";
            Console.WriteLine(Result);

            #endregion Compare Values



            Console.ReadLine();
        }
    }

    public class student 
    {
      public string Firstname; 
      public string Lastname;

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }

        public override bool Equals(object obj)
        {
            student s = obj as student;

            return this.Firstname.Equals(s.Firstname) &&
            this.Lastname.Equals(s.Lastname); 
        }

        public override int GetHashCode()
        {
            return this.Firstname.GetHashCode() ^ this.Lastname.GetHashCode() ;
        }

    }
}
