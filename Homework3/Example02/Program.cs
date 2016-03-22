using ScoreCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students = new Student[3]
            {
                new Student ( "AAA", 100, 84, 59),
                new Student ( "BBB", 64, 92, 80),
                new Student ( "CCC", 70, 94, 40)
            };
            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine(students[1]);
            };
        }
    }
}