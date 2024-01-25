using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_GenericDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate Deligate
            Predicate<int> d1 = Method1;
            bool b1 = d1(20);
            Console.WriteLine(b1);
            //Predicate<int> d2 = Method1;
            bool b2 = d1(21);
            Console.WriteLine(b2);

            Predicate<string> d2 = Method2;
            bool b3 = d2("Pranav");
            Console.WriteLine(b3);
            
            bool b4= d2("Ashu");
            Console.WriteLine(b4);

            #endregion Predicate Deligate

            #region Action Delegate

            Action<string> d5 = Print;
            d5("pranav");
            
            //...............//

            Action<string, String, int> d6 = PrintA;
            d6("Pranav", "Yadav", 21);

            #endregion Action Delegate

            #region Funk Delegate
            Console.WriteLine("** Funk Delegate **");

            Func<string, int> d7 = Print1;
            int i = d7("OM");
            Console.WriteLine(i);

            Func<int, int, int> d8 = Add;
            int i1 = d8(21, 21);
            Console.WriteLine(i1);

            #endregion Funk Delegate

            //.. Ananomous Methgod ..//

            Func<int, int, int> d9 = delegate (int a, int b)
            {
                return a + b;
            };

            i1 = d9(50, 50);
            Console.WriteLine($"{i1}");


            Console.ReadLine();
        }
        

        static bool Method1(int i)
        {
            return i % 2 == 0 ? true : false;
        }
        static bool Method2(string s)
        {
            return s.Length > 4 ? true : false;
        }

        static void Print(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        static void PrintA(string s1, string s2, int i)
        {
            Console.WriteLine($"{s1} : {s2} : {i}");
        }

        static int Print1(string s)
        {
            return s.Length;
        }

        static int Add(int a , int b)
        {
            return a + b;
        }
    }
}
