using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public class PLAYER : MOVINGOBJECT
    {
        public PLAYER(int x, int y, int speed, int effecttime)
            : base(x, y, speed)
        {
            this.Effecttime = effecttime;
        }

        public new int X { get; set; }

        public new int Y { get; set; }

        public new int Speed { get; set; }

        public int Effecttime { get; set; }

        public void Changeeffecttime(int speed, int effecttime)
        {
            if (this.Speed + speed > 0 & this.Effecttime + effecttime > 0)
            {
                this.Speed += speed;
                this.Effecttime += effecttime;
            }
        }

        public void Move(int x, int y, BARRIER barrier, BONUS bonus)
        {
            if (!(barrier.X == this.X + x) & !(barrier.Y == this.Y + y))
            {
                if (x >= base.X & x <= 0)
                {
                    throw new Exception("player can not be located abroad, error x");
                }

                if (y >= base.Y & y <= 0)
                {
                    throw new Exception("player can not be located abroad, error y");
                }

                this.X = x;
                this.Y = y;
            }

            if (bonus.X == this.X + x & bonus.Y == this.Y + y)
            {
                this.Speed += bonus.Speedincrease;
                this.Effecttime += bonus.Effecttime;
            }
        }
    }
}
