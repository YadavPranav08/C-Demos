using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_CompanyLibrary
{
    public delegate bool PramoteCriteria(Employee e);
    public class Company
    {
        public int CompanyId {  get; set; }
        public string Name { get; set; }

        public Employee[] Employees { get; set; }
         
        public Company(Employee[] emps)
        {
            Employees = emps;
        }

        public string this[int id]
        {
            get
            {
                string name = "NO EMPLOYEE"; // string.Empty; // " ";

                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].EmployeeID == id)
                    {
                        name =Employees[i].Name ;
                        break;
                    }
                }

                return name;
            }
            
            set
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].EmployeeID == id)
                    {
                        Employees[i].Name = value;
                    }
                }
            }   
        }

        public Employee this[string name]
        {
            get
            {
                for(int i = 0; i < Employees.Length; i++)
                {
                    if (Employees[i].Name == name)
                    {
                        return Employees[i];
                    }
                }
                return null;
            }
        }

        public void Details()
        {
            Console.WriteLine($"CompanyId: {CompanyId}, Name: {Name}");
        }

        public void AllEmployees()
        {
            if (Employees != null & Employees.Length > 0)
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    Console.WriteLine($"Employee Id : {Employees[i].EmployeeID}" +
                        $" Name: {Employees[i].Name}, City: {Employees[i].City}," +
                        $" Experience: {Employees[i].Experience}");
                }
            }
            else
            {
                Console.WriteLine($"NO EMPLOYEES IN COMPANY");
            }

        }

        public void Pramot(PramoteCriteria del)
        {

            Console.WriteLine("** Pramoted Employees **");

            if(Employees != null & Employees.Length > 0)
            {
                for( int i = 0; i < Employees.Length; i++)
                {
                    //if (Employees[i].Experience > 3)
                    if (del(Employees[i]))
                    {
                        Console.WriteLine ($"{Employees[i].Name} is Pramoted");
                    }
                }
            }
            else
            {
                Console.WriteLine("NO EMPLOYEE PROMOTED");    
            }
        }

    }
}
