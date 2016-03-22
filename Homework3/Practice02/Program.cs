using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 999; i++)
            {
                i = i + 1;
                sum += i;
                //Console.WriteLine(i);
            }
            Console.WriteLine(sum);
        }
    }
}