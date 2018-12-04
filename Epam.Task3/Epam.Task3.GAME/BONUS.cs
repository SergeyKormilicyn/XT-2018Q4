using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public abstract class BONUS : TERRITORY
    {
        public BONUS(int x, int y, int speedincrease)
        {
            if (x >= base.X & x <= 0)
            {
                throw new Exception("bonus can not be located abroad, error x");
            }

            if (y >= base.Y & y <= 0)
            {
                throw new Exception("bonus can not be located abroad, error y");
            }

            if (speedincrease > 0)
            {
                throw new Exception("speed bonus can not be negative");
            }

            if (this.Effecttime > 0)
            {
                throw new Exception("time bonus can not be negative");
            }

            this.X = x;
            this.Y = y;
            this.Speedincrease = speedincrease;
        }

        public new int X { get; set; }

        public new int Y { get; set; }

        public int Speedincrease { get; set; }

        public int Effecttime { get; set; }
    }
}
