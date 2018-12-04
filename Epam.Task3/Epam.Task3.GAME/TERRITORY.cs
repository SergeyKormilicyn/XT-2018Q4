using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    abstract class TERRITORY
    {
        public int x { get; }
        public int y { get; }

        public TERRITORY()
        {
            this.x = 25;
            this.y = 25;
        }
    }
}
