using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.ROUND
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double x;
            double y;
            ROUND сircle;

            while (true)
            {
                Console.WriteLine("enter a radius more than or equal to 0");
                if (double.TryParse(Console.ReadLine(), out radius) & radius >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering radius");
                }
            }

            while (true)
            {
                Console.WriteLine("enter x coordinate");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering x");
                }
            }

            while (true)
            {
                Console.WriteLine("enter y coordinate");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering y");
                }
            }

            сircle = new ROUND(radius, x, y);
            Console.WriteLine($"Circle length = {сircle.Circle_length}");
            Console.WriteLine($"Area circle = {сircle.Area_circle}");
        }
    }
}
