using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int totCourses = (int)Math.Ceiling((double)numPeople / capacity);
            Console.WriteLine(totCourses);

        }
    }
}
