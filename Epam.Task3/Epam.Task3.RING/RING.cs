using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.RING
{
    public class RING : ROUND.ROUND
    {
        private double outerradius;
        private double arearing;
        private double ringlength;

        public RING(double radius, double x, double y, double outerradius)
            : base(radius,  x,  y)
        {
            if (outerradius < 0)
            {
                throw new Exception("Insideradius should be positive");
            }

            if (radius  >= outerradius)
            {
                throw new Exception("Insideradius should be more radius");
            }

            this.outerradius = outerradius;
            this.Area_Ring();
            this.Ring_Length();
        }

        public double Outer_radius
        {
            get
            {
                return this.outerradius;
            }
        }

        public double Ring_length
        {
            get
            {
                return this.ringlength;
            }
        }

        public double Area_ring
        {
            get
            {
                return this.arearing;
            }
        }

        private void Area_Ring()
        {
            this.arearing = Math.PI * (Math.Pow(this.outerradius, 2) - Math.Pow(this.Radius, 2));
        }

        private void Ring_Length()
        {
            this.ringlength = (2 * Math.PI * this.outerradius) + this.Circle_length;
        }
    }
}
