using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    abstract class BONUS : TERRITORY
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speedincrease { get; set; }
        public int effecttime { get; set; }

        public BONUS(int x, int y, int speedincrease)
        {
            if (x >= base.x & x <= 0)
            {
                throw new Exception("bonus can not be located abroad, error x");
            }

            if (y >= base.y & y <= 0)
            {
                throw new Exception("bonus can not be located abroad, error y");
            }

            if (speedincrease > 0)
            {
                throw new Exception("speed bonus can not be negative");
            }

            if (effecttime > 0)
            {
                throw new Exception("time bonus can not be negative");
            }

            this.x = x;
            this.y = y;
            this.speedincrease = speedincrease;
        }
    }
}
