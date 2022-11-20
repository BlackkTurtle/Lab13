using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Student
    {
        public Student(string[] strarray)
        {
            FirstName = strarray[0];
            LastName = strarray[1];
            Group = Convert.ToInt32(strarray[2]);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
    }
}
