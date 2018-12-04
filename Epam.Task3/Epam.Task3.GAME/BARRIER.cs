using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    abstract class BARRIER : TERRITORY
    {
        public int x { get; set; }
        public int y { get; set; }
        public string color { get; set; }

        public BARRIER(int x, int y, string color)
        {
            if (x >= base.x & x <= 0)
            {
                throw new Exception("barrier can not be located abroad, error x");
            }

            if (y >= base.y & y <= 0)
            {
                throw new Exception("barrier can not be located abroad, error y");
            }

            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
