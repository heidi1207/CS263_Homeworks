    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class Player
    {
        public int showplayer(string show)
        {
          switch (show)
          {
           case "1": return 1;
           case "2": return 2;
           case "3": return 3;
           default: return 0;
          }
        }
    }
}
