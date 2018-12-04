using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    public abstract class ENEMY : MOVINGOBJECT
    {
        private Random rnd;

        public ENEMY(int x, int y, int speed)
            : base(x, y, speed)
        {
        }
        
        public new int X { get; set; }

        public new int Y { get; set; }

        public new int Speed { get; set; }

        public void ArtificialIntelligence(BARRIER barrier)
        {
            while (true)
            {
                try
                {
                    this.rnd = new Random();
                    this.Move(this.rnd.Next(-1, 1), this.rnd.Next(-1, 1), barrier);
                }
                catch
                {
                    Console.WriteLine("there can not move");
                }

                break;
            }
        }
    }
}
