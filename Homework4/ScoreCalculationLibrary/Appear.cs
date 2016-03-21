using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Appear
    {
        private string name;
        private double chinese;
        private double english;
        private double math;

        public double Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }

        public double English
        {
            get { return english; }
            set { english = value; }
        }

        public double Math
        {
            get { return math; }
            set { math = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void aStudent(string name, double chinese, double english, double math)
        {
            Student student = new Student();
            Console.Write("請輸入姓名:");
            name = Console.ReadLine();
            do
            {
                Console.Write("請輸入國文成績:");
            } while (!double.TryParse(Console.ReadLine(), out chinese));

            do
            {
                Console.Write("請輸入英文成績:");
            } while (!double.TryParse(Console.ReadLine(), out english));

            do
            {
                Console.Write("請輸入數學成績:");
            } while (!double.TryParse(Console.ReadLine(), out math));

            this.Name = name;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
            student = new Student(Name, Chinese, English, Math);
            Console.WriteLine(student);
        }
    }
}