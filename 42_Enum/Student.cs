using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Enum
{
    public class Student
    {
        public int Rollnumber { get; set; }
        public string Name { get; set; }
        //public string Gender { get; set; }
        //public int Gender { get; set; }
        public Gender Gender { get; set; }

        //public string Subject { get; set; }
        public Subject Subject { get; set; }
    }

    public enum Gender
    {
        Male=1, Female, unknown
    }
    
    public enum Subject
    {
     Marathi=1,
     Sanscrit,
     English,
     Mathematics,
     Science,
     Social_Science,
    }
}
