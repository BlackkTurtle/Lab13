using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Student
    {
        public Student(string[] strarray)
        {
            FirstName = strarray[0];
            LastName = strarray[1];
            Age = Convert.ToInt32(strarray[2]);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
