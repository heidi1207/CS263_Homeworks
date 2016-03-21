using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Car.TotalCars = 5;
            Car.Add(new Car(), new Car());
            Console.WriteLine(Car.TotalCars);
        }
    }
}