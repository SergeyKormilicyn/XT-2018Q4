using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.GAME
{
    abstract class ENEMY : MOVINGOBJECT
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public Random rnd;

        public ENEMY(int x, int y, int speed)
            : base(x, y, speed)
        { }

        public void ArtificialIntelligence(BARRIER barrier)
        {
            while (true)
            {
                try
                {
                    this.rnd = new Random();
                    Move(this.rnd.Next(-1, 1), this.rnd.Next(-1, 1), barrier);

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
