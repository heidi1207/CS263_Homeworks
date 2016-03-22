using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Student
    {
        public string name;
        public Grade[] grades;

        public Student()
        { }

        public Student(string name, double chinese, double english, double math)
        {
            this.name = name;
            this.grades = new Grade[3]
            {
                 new Grade { subject = "國文", value = chinese },
                 new Grade { subject = "英文", value = english },
                 new Grade { subject = "數學", value = math }
            };
        }

        public Student SetGrades(double chinese, double english, double math)
        {
            this.grades = new Grade[3]
           {
                 new Grade { subject = "國文", value = chinese },
                 new Grade { subject = "英文", value = english },
                 new Grade { subject = "數學", value = math }
           };
            return this;
        }

        public double GetTotalGrade()
        {
            double total = 0.0;
            for (int index = 0; index < this.grades.Length; index++)
            {
                total = total + grades[index].value;
            }
            return total;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("學生名稱: {0}\n", this.name);
            result += string.Format("{0}\n", grades[0]);
            result += string.Format("{0}\n", grades[1]);
            result += string.Format("{0}\n", grades[2]);
            result += string.Format("總分: {0}", this.GetTotalGrade());
            return result;
        }
    }
}