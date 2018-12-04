using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VECTOR_GRAPHICS_EDITOR
{
    public class CIRCUMFERENCE : ROUND.ROUND
    {
        private double radiustwo;

        public CIRCUMFERENCE(double radius, double x, double y, double radiustwo)
            : base(radius, x, y)
        {
            if (radiustwo < 0)
            {
                throw new Exception("radius two should be positive");
            }

            this.radiustwo = radiustwo;
        }

        public double Radiustwo
        {
            get
            {
                return this.radiustwo;
            }
        }
    }
}
