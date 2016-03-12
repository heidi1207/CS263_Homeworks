using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student1 First = new Student1();
            First.studentID = 001;
            string result = First.Content("Heidi", "台北市忠孝東路", "(02)88779900", "aaa@gmail.com");
            Console.WriteLine(result);
        }
    }
}