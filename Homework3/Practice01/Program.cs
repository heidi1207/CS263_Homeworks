using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1.剪刀 2.石頭 3.布");
            string show1 = Console.ReadLine();
            Computer computers = new Computer();
            Judge judges = new Judge();
        }
    }
}