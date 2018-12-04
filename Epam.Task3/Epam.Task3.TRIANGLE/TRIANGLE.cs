using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.TRIANGLE
{
    public class TRIANGLE
    {
        private double a;
        private double b;
        private double c;

        public TRIANGLE(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("the side of the triangle cannot be less than or equal to 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception("the sum of the two sides cannot be more or equal than the other");
            }

             this.a = a;
             this.b = b;
             this.c = c;
        }

        public double CalcPerimeter()
        {
            return this.a + this.b + this.c;
        }

        public double CalcArea()
        {
            double p = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }
}
