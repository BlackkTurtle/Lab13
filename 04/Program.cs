using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Students = new List<Student>();
            while (true)
            {
                var strarray = Console.ReadLine().Split(' ');
                if (strarray[0] == "End" || strarray[0] == "END")
                {
                    break;
                }
                else
                {
                    Students.Add(new Student(strarray));
                }
            }
            var newlist = Students.OrderBy(x => x.LastName).ThenByDescending(x => x.FirstName);
            foreach (var student in newlist)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.ReadLine();
        }
    }
}
