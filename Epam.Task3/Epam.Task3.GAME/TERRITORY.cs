using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public abstract class TERRITORY
    {
        public TERRITORY()
        {
            this.X = 25;
            this.Y = 25;
        }

        public int X { get; }

        public int Y { get; }
    }
}
