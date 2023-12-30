using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            if (i == 10)
            {
                Console.WriteLine($"{i} : TEN");
            }
            else
            {
                Console.WriteLine($"{i} : NOT TEN");
            }

            // ternary operator
            // if else = condition ? statement 1 : statement 2

            int i1 = 100;
            string Result = (i1 == 10) ? "TEN" : "NOT TEN";
            Console.WriteLine($"i1 : {i1} : {Result}");

            int j = 50;

            if (j == 10)
            {
                Console.WriteLine($"j : {j}: TEN");
            }
            else if (j == 20)
            {
                Console.WriteLine($"j : {j}: TWENTY");
            }
            else if (j == 30)
            {
                Console.WriteLine($"j :{j}: THIRTY");
            }
            else

            {
                Console.WriteLine($"j :{j} : NO 10,20,30");
            }

            // case - break = switch


            int j1 = 30;
            switch (j1)
            {

                case 10:
                    
                        Console.WriteLine($"j : {j1}: TEN");
                    break;

                case 20:
                    
                        Console.WriteLine($"j : {j1}: TWENTY");
                    
                    break;
                case 30:
                    
                        Console.WriteLine($"j :{j1}: THIRTY");
                    
                    break;
                default:

                    
                        Console.WriteLine($"j :{j1} : NO 10,20,30");
                    
                    break;
            }

            int a = 10, b = 10;
            if (a < b)
            {
                Console.WriteLine($"b:{b} is gretter than a:{a}");
            }
            else if (a >b)
            {
                Console.WriteLine($"a:{a} is gretter than b:{b}");
            }
            else
            {
                Console.WriteLine($"a:{a} & b:{b} are equal");            
            }



            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            Console.ReadLine();
        }
    }
}
