using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string intro = "My ";
            //intro += "Name ";
            //intro += "is ";
            //intro += "Khan.";
            //Console.WriteLine(intro);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hii ");
            sb.Append("Good ");
            sb.Append("Morning All Of You..!");
            Console.WriteLine(sb.ToString());


            Console.ReadLine();
        }
    }
}
