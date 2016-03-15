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
            Console.WriteLine("請輸入第一個數字");
            int number1 = 0;
            int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("請輸入第二個數字");
            int number2 = 0;
            int.TryParse(Console.ReadLine(), out number2);
            int number3 = number1 + number2;
            Console.WriteLine("您輸入的數字相加後等於 \"{0}\"", number3);
        }
    }
}