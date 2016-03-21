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
            Employee employee = new Employee();
            employee.BaseSalary = 5000;
            employee.Benefit = 4000;
            int test = employee.Salary;
            Console.WriteLine(test);
        }
    }
}