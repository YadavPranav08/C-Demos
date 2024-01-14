using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_VarDaynamicKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region var keyword
            //  // ?? i = 10; // ?? -> int/ object
            //  // ?? c = '$'; // ?? -> char / object
            //  // ?? s = new Student(); // ?? -> Student / object

            // //object o = new { Id = 10, Name = "Mahesh" }; // ?? -> object
            //var o = new { Id = 10, Name = "Mahesh" }; // ?? -> object
            //Console.WriteLine($"Id : {o.Id} Name : {o.Name}");

            //var i = 100;
            //Console.WriteLine(i);

            //var v = "GANESH";
            //Console.WriteLine(v);

            //var f = 10.5f;
            //Console.WriteLine(f);

            //var i1 = '%';
            //Console.WriteLine(i1.GetType().Name);
            ////i1 = "Pranav";

            #endregion var keyword

            #region dynamic Keyword

            //dynamic d = 10;
            //Console.WriteLine(d.GetType().Name);
            //d = "Mahesh";          // runtime error
            //Console.WriteLine(d.GetType().Name);
            //Console.WriteLine(d);

            ////var v = 10;
            ////v = "Mahesh";        // compiler error

            //dynamic s = "Vikas";
            //dynamic s1 = new Student();
            //dynamic o = new {Id = 10, Name = "Pravin", Gender = "Male"};




            #endregion dynamic Keyword

            var i = 10;
            var i1 = "Kumar";
            Console.WriteLine(i1);

            dynamic i2 = 10;
            i2 = "Kumar";
            Console.WriteLine(i2);

            object i3 = 10;
            i3 = "Kumar";
            Console.WriteLine(i3);


            Console.ReadLine();
        }
    }

    public class Student
    {

    }
}
