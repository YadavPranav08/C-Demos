using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    public class Calculator
    {
        #region using method overloding
        //public bool AreEqual(int a, int b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}
        #endregion using method overloding

        #region using object keyword

        //// Problems with object type
        //// 1. there is no type safety
        //// 2. Chances of boxing and unboxing operations
        //public bool AreEqual(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        #endregion using object keyword

        #region using generics 

        public bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public void Add<T>(T a, T b)
        {
            dynamic y = a;
            dynamic z = b;
            Console.WriteLine(y + z);
        }

        #endregion using generics 

    }
}
