using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class Computer
    {
        public string Fist
        {
            get;
            set;
        }
        public int showCom()
        {
            Random random = new Random();
            int rcompu = random.Next(1, 4);
            string startcompu = string.Empty;
            switch (rcompu)
            {
                case 1:
                    startcompu = "剪刀";
                    break;
                case 2:
                    startcompu = "石頭";
                    break;
                case 3:
                    startcompu = "布";
                    break;
            }
            return rcompu;
        }
    }
}
