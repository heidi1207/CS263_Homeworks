using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice04
{
    public class Math
    {
        private double x;

        //private int squre;
        public double Squre
        {
            get { return this.x * this.x; }
            set
            {
                if (value < 0)
                {
                    this.x = 10 * 2;
                }
                else
                    this.x = value;
            }
        }
    }
}