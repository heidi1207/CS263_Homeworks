using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("現在是幾月?");
            int season = 0;
            int.TryParse(Console.ReadLine(), out season);
            switch (season)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("現在是春季");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("現在是夏季");
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine("現在是秋季");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("現在是冬季");
                    break;
            }
        }
    }
}