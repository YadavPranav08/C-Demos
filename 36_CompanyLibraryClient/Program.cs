using _36_CompanyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_CompanyLibraryClient
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee()
            //{ EmployeeID = 1, Name = "Pranav", City = "Shripur", Experience = "One Year", };
            //e.Details();
            //e.Company = new Company() { CompanyId  = 1, Name = "TATA" };
            //Console.WriteLine($"CompanyId: {e.Company.CompanyId}, Name: {e.Company.Name}");   

            //Company c = new Company()
            //{CompanyId= 123, Name= "YADAV CONSULTANCY" };
            //c.Details();
            ////c.Employees();


            Employee e1 = new Employee() 
            {EmployeeID=1234, Name="Pranav", City="shripur", Experience= 2};

            Employee e2 = new Employee()
            { EmployeeID = 1235, Name = "Ashu", City = "Pawar", Experience = 4};

            Employee e3 = new Employee()
            { EmployeeID = 1236, Name = "Vikas", City = "mp", Experience = 1};

            Employee e4 = new Employee()
            { EmployeeID = 1237, Name = "Akshay", City = "Kasture", Experience = 5};

            Employee[] employees = new Employee[] 
            {e1, e2, e3, e4 };

            Company c = new Company(employees) 
            {CompanyId=987, Name= "TATA"};
            c.Details();
            c.AllEmployees();
            // c.Pramot();     

            PramoteCriteria del = Pramotionlogic;
            c.Pramot(del);

            PramoteCriteria del1 = Pramotionlogic2;
            c.Pramot(del1);

            //...................//

            // Company c2 = new Company(employees) { };

            //string name = c[1234];           // ID to name // 
            //Console.WriteLine($"Employee Name: {name}");   // Pranav

            //c[1234] = "Shital";             // name change //
            //name = c[1234];
            //Console.WriteLine($"Employee Name: {name}");   // Shital

            //Employee e = c["Shital"];      // name to all details
            //Console.WriteLine($"{e.Name}, {e.EmployeeID}, {e.City}, {e.Experience}");


            Console.ReadLine();
        }

        // call back function //
        static bool Pramotionlogic(Employee e)
        {
            return e.City == "Pawar";
        }
        static bool Pramotionlogic2(Employee e)
        {
            return e.Experience == 2;
        }

    }
}
