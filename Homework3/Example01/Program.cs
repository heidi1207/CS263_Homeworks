using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoreCalculationLibrary;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student
            {
                name = "Heidi",
                chinese = new Grade { subject = "國文", value = 90 },
                english = new Grade { subject = "英文", value = 60 },
                math = new Grade { subject = "數學", value = 40 }
            };
            Console.WriteLine(aStudent);
        }
    }
}
