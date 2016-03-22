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
            Random random = new Random();
            for (int index = 0; index <= 100; index++)
            {
                Console.WriteLine(random.Next(1, 101));
            }
        }
    }
}