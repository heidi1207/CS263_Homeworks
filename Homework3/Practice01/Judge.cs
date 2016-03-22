using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class Judge
    {
        public enum Result
        {
          玩家贏,
          電腦贏,
          平手
        }
       
        public Result winner(int playernum, int computernum)
        {
            int result = playernum - computernum;
            if (result == -1 || result == 2)
            {
                return Result.玩家贏;
            }
            else if (result == 0)
            {
                return Result.平手;
            }
            else
            {
                return Result.電腦贏;
            }
        }


    }
}
