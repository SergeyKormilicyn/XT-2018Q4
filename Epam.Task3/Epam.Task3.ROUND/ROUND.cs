using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.ROUND
{
    public class ROUND
    {
        private double radius;
        private double x;
        private double y;
        private double circlelength;
        private double areacircle;

        public ROUND(double radius, double x, double y)
        {
            if (radius < 0)
            {
                throw new Exception("Radius should be positive");
            }

            this.radius = radius;
            this.x = x;
            this.y = y;
            this.Circle_Length();
            this.Area_Circle();
        }

        public double Circle_length
        {
            get
            {
                return this.circlelength;
            }
        }

        public double Area_circle
        {
            get
            {
                return this.areacircle;
            }
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }
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

        private void Circle_Length()
        {
            this.circlelength = 2 * Math.PI * this.radius;
        }

        private void Area_Circle()
        {
            this.areacircle = Math.PI * Math.Pow(this.radius, 2);
        }
    }
}
