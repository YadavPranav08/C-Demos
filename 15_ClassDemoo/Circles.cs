using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassDemoo
{
    internal class Circles
    {

        // static
        // if some value are fix for all then we put these value in
        // class with the help of (static) keyword

        public int Radius;               // instance member
        public static float Pi = 3.14f;  // static member


        public void Area()
        {
            Console.WriteLine($"AREA OF CIRCLE = {Pi * Radius * Radius}");
        }
    }
}
