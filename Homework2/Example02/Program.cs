using StudentLibrary;
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
            Student aStudent = new Student
            {
                name = "Heidi",
                isHappy = false,
                email = "abc@gmail.com",
                address = "Taipei",
                website = "www.abc.com"
            };

            aStudent.DoSomething();
            Console.WriteLine(aStudent.name);
            Console.WriteLine(aStudent.isHappy);
            Console.WriteLine(aStudent.email);
            Console.WriteLine(aStudent.address);
            Console.WriteLine(aStudent.website);
        }
    }
}