using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    class PLAYER : MOVINGOBJECT
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public int effecttime { get; set; }

        public PLAYER(int x, int y, int speed, int effecttime)
            :base( x,  y,  speed)
        {
            this.effecttime = effecttime;
        }

        public void Changeeffecttime(int speed, int effecttime)
        {
            if (this.speed + speed > 0 & this.effecttime + effecttime > 0)
            {
                this.speed += speed;
                this.effecttime += effecttime;
            }
        }

        public void Move(int x, int y, BARRIER barrier, BONUS bonus)
        {
            if (!(barrier.x == this.x + x) & !(barrier.y == this.y + y))
            {
                if (x >= base.x & x <= 0)
                {
                    throw new Exception("player can not be located abroad, error x");
                }

                if (y >= base.y & y <= 0)
                {
                    throw new Exception("player can not be located abroad, error y");
                }

                this.x = x;
                this.y = y;
            }

            if (bonus.x == this.x + x & bonus.y == this.y + y)
            {
                this.speed += bonus.speedincrease;
                this.effecttime += bonus.effecttime;
            }
        }
    }
}
