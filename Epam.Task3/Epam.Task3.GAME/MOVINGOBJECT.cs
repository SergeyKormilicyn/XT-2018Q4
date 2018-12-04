using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public abstract class MOVINGOBJECT : TERRITORY
    {
        public MOVINGOBJECT(int x, int y, int speed)
        {
            if (x >= base.X & x <= 0)
            {
                throw new Exception("object can not be located abroad, error x");
            }

            if (y >= base.Y & y <= 0)
            {
                throw new Exception("object can not be located abroad, error y");
            }

            if (speed > 0)
            {
                throw new Exception("object can not be negative");
            }

            this.X = x;
            this.Y = y;
            this.Speed = speed;
        }

        public new int X { get; set; }

        public new int Y { get; set; }

        public int Speed { get; set; }

        public void Move(int x, int y, BARRIER barrier)
        {
            if (!(barrier.X == this.X + x) & !(barrier.Y == this.Y + y))
            {
                if (x >= base.X & x <= 0)
                {
                    throw new Exception("object can not be located abroad, error x");
                }

                if (y >= base.Y & y <= 0)
                {
                    throw new Exception("object can not be located abroad, error y");
                }

                this.X = x;
                this.Y = y;
            }
        }
    }
}
