using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02___overflow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte number0 = 254;
            byte x = 1;
            float number1 = (byte)number0 + (byte)x;
            float number2 = (byte)number1 + (byte)x;
            Console.WriteLine(number0);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}