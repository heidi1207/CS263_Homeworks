using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int val = 0;
            do
            { Console.Write("請輸入一個值: "); }
            while
                (!int.TryParse(Console.ReadLine(), out val));
            Math math = new Math();
            math.Squre = val;
            Console.WriteLine(math.Squre);
        }
    }
}