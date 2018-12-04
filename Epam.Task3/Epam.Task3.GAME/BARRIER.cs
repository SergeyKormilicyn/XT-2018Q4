using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public abstract class BARRIER : TERRITORY 
    {
        public BARRIER(int x, int y, string color)
        {
            if (x >= base.X & x <= 0)
            {
                throw new Exception("barrier can not be located abroad, error x");
            }

            if (y >= base.Y & y <= 0)
            {
                throw new Exception("barrier can not be located abroad, error y");
            }

            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public new int X { get; set; }

        public new int Y { get; set; }

        public string Color { get; set; }
    }
}
