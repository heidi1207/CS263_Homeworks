using ScoreCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Appear appear = new Appear();
            appear.aStudent(appear.Name, appear.Chinese, appear.English, appear.Math);
        }
    }
}