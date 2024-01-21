﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    public class Student<T1, T2>
    {
        public T1 Rollnumber { get; set; } 
        public T2 Name { get; set;}

        public T2 Details()
        {
            dynamic result = ($"{ Rollnumber} : { Name}");
            return result;
        } 

    }
}
