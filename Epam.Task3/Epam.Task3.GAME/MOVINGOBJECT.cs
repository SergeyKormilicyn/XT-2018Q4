using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    abstract class MOVINGOBJECT : TERRITORY
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }

        public MOVINGOBJECT(int x, int y, int speed)
        {
            if (x >= base.x & x <= 0)
            {
                throw new Exception("object can not be located abroad, error x");
            }

            if (y >= base.y & y <= 0)
            {
                throw new Exception("object can not be located abroad, error y");
            }

            if (speed > 0)
            {
                throw new Exception("object can not be negative");
            }

            this.x = x;
            this.y = y;
            this.speed = speed;
        }

        public void Move(int x, int y, BARRIER barrier)
        {
            if (!(barrier.x == this.x + x) & !(barrier.y == this.y + y))
            {
                if (x >= base.x & x <= 0)
                {
                    throw new Exception("object can not be located abroad, error x");
                }

                if (y >= base.y & y <= 0)
                {
                    throw new Exception("object can not be located abroad, error y");
                }

                this.x = x;
                this.y = y;
            }
        }
    }
}
