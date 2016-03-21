using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Employee
    {
        private int baseSalary;

        public int BaseSalary
        {
            get
            {
                return this.baseSalary;
            }

            set
            {
                if (value < 0)
                {
                    this.baseSalary = 0;
                }
                else if (value > 50000)
                {
                    this.baseSalary = 50000;
                }
                else
                    this.baseSalary = value;
            }
        }

        private int benefit;

        public int Benefit
        {
            get
            {
                return benefit;
            }

            set
            { this.benefit = value < 0 ? 0 : value; }
        }

        public int Salary
        {
            get
            {
                return this.Benefit + this.BaseSalary;
            }
        }
    }
}