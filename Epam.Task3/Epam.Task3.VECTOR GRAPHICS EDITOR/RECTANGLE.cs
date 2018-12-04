using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VECTOR_GRAPHICS_EDITOR
{
    public class RECTANGLE
    {
        private double a;
        private double b;
        private double x;
        private double y;

        public RECTANGLE(double a, double b, double x, double y)
        {
            if (a <= 0)
            {
                throw new Exception("Side \"a\" should be positive");
            }

            if (b <= 0)
            {
                throw new Exception("Side \"b\" should be positive");
            }

            this.a = a;
            this.b = b;
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public double A
        {
            get
            {
                return this.a;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
        }
    }
}
