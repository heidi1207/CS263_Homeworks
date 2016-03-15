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
            //Console.WriteLine("請輸入一個數字");
            //int number = -10;
            //Console.WriteLine("轉成功了嗎? {0}", int.TryParse(Console.ReadLine(), out number));
            //Console.WriteLine("您輸入的是 " + number);
            //Console.WriteLine("您輸入的是 \"{0}\"", number);
            decimal a = 0.1M;
            decimal b = 0.2M;
            decimal c = 0.3M;
            Console.WriteLine(a + b == c);
        }
    }
}