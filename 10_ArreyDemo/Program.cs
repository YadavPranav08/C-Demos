using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_ArreyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring Arrey = first way

            int[] fees = new int[5];     // arrey size is fixed
            fees[0] = 10000;
            fees[1] = 30000;
            fees[2] = 50000;
            fees[3] = 40000;
            fees[4] = 25000;

            Console.WriteLine($"Number of item : {fees.Length}");

            for (int i = 0; i < fees.Length; i++)
            { 
              Console.WriteLine( $"{fees[i]}" );
            }

            // declaring Arrey = second way

            string[] students = new string[] { "pranav", "dada", "pratiksha", "krishna"  };

            Console.WriteLine($"Number of item : {students.Length}");

            for ( int i = 0; i < students.Length; i++ ) 
            {
                Console.Write($"{students[i]} ");
                    
            }
            //

            string[] emails = null;
            emails = new string[] { "a@a.com", "p@p.com", "v@v.com" };

            Console.WriteLine($"\nNumber of item : {emails.Length}");

            for (int i = 0; i < emails.Length; i++)
            {
                Console.Write($"{emails[i]} ");
            }

            // reverse arrey

            int[] numbers = new int [] {1, 2, 3, 4, 5 };

            Console.WriteLine($"\nNumbers of number : {numbers.Length}");

            Console.Write($"\noriginal output");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]} ");
            }

            Console.Write($"\n reverse output");
            for (int i = numbers.Length-1; i >= 0; i--) 
            {
                Console.Write($" {numbers[i]} ");
            }



            // find highest number

            numbers = new int[] { 122, 125, 224, 364, 500, 415 };
            Console.WriteLine($"\nNumbers of number : {numbers.Length}");
            int highest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > highest)
                    {
                        highest = numbers[j]; 
                    }
                }
            }
            Console.WriteLine($"\nhighest number : {highest}");


            // reverse input in string

            Console.WriteLine("Please enter your name");
           string name = Console.ReadLine();

             string reversename = string.Empty;
            for (int i = name.Length-1;  i >= 0; i-- )
            {
                reversename += name[i];
            }

            Console.WriteLine($"Input : {name} ; Output : {reversename}");

            // reverse word in sentence
            // means how are you = you are how

            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            string[] Word = sentence.Split(new char[] { ' ' });

            for (int i = Word.Length-1; i >= 0;i--)
            {
                Console.Write($"{Word[i]} ");
            }


            // new example,,,  even number
            int[] no = new int[] { 16, 24, 25, 38, 37, 27, 30 };
            
            int a = 0;
            for(int i = 0; i < no.Length; i++ )
            {
                if (no[i] % 2 == 0 )
                {
                    Console.Write($"\neven number : {no[i]}");
                    a++;
                }
                else 
                {
                    Console.Write($"\nodd number : {no[i]}");
                }
            }





            Console.ReadLine();
        }
    }
}
