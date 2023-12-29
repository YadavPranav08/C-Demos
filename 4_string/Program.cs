using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Pr@n@v";
            Console.WriteLine(name);

            Console.WriteLine(name.Length);

            name = "Vaishnavi"; 
            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            name = "Vaishu";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            name = "   Pranav";
            Console.WriteLine(name);
            Console.WriteLine(name.Trim()); // to removee space
            Console.WriteLine(name.ToUpper()); // for write in upper case
            Console.WriteLine(name.ToLower()); // for write in lower case

            name = "\"Pranav\"";
            Console.WriteLine(name);  // "Pranav"

            name = "\\Pranav\\";
            Console.WriteLine(name); // \Pranav\

            Console.WriteLine("Pranav Yadav");  // direct name 
            Console.WriteLine("Pranav\tyadav"); // \t= 3 space
            Console.WriteLine("pranav\nYadav"); // \n = second line

            string path = "C:\\Users\\prana\\Desktop\\Pranav Doc\\IT CLASS";
            // in VS 2022 it is automatically read and take double \ for link
            Console.WriteLine(path);     


            path = @"C:\Users\prana\Desktop\Pranav Doc\IT CLASS";
            Console.WriteLine(path);

            string firstname = "pranav";
            string lastname = "yadav";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);  // pranavyadav

            fullname = firstname + " " + lastname;
            Console.WriteLine(fullname); // pranav yadav

            // use concat function for + neglect and write

            fullname = string.Concat(firstname, " " , lastname);
            Console.WriteLine(fullname);

            string middlename = "santosh";
            fullname = string.Concat(firstname + " " + middlename+ " " + lastname);
            Console.WriteLine(fullname);

            firstname = "pratiksha";
            middlename = "santosh";
            lastname = "yadav";
            fullname = string.Concat (firstname + " " + middlename + " " + lastname);   
            Console.WriteLine(fullname); // pratiksha santosh yadav

            fullname = string.Join (" " ,firstname, middlename, lastname);
            Console.WriteLine (fullname); // pratiksha santosh yadav

            // full name : pranav santosh yadav

            fullname = string.Join(" ", "full", "name", ":" ,firstname, middlename,lastname);
            Console.WriteLine(fullname);

            // placeholder syntax
            fullname = string.Format("full name : {0} {1} {2}", firstname, middlename, lastname);
            Console.WriteLine(fullname);

            // strig interpolation syntax
            // no need of {0}, {1}, {2}

            fullname = "full name : {firstname} {middlename} {lastname}";
            Console.WriteLine(fullname);

            fullname = $"full name : {firstname} {middlename} {lastname}";
            Console.WriteLine(fullname); // $ - most usefull












            Console.ReadLine();
        }
    }
}
