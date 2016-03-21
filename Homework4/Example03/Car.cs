using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Car
    {
        private static int totalCars;

        public Car()
        {
            Car.TotalCars++;
        }

        public static int TotalCars
        {
            get { return Car.totalCars; }
            private set { Car.totalCars = value; }
        }

        public static int Add(Car car1, Car car2)
        {
            return 0;
        }
    }
}