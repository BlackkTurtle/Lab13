using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Student
    {
        public Student(string[] strarray)
        {
            FirstName = strarray[0];
            LastName = strarray[1];
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
