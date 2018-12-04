using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.RING
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double outerradius;
            double x;
            double y;
            RING ring;

            while (true)
            {
                Console.WriteLine("enter a radius more than or equal to 0");
                if (double.TryParse(Console.ReadLine(), out radius) & radius >= 0)
                {
                    Console.WriteLine("enter a outer radius more than or equal to 0");
                    if (double.TryParse(Console.ReadLine(), out outerradius) & outerradius >= 0)
                    {
                        if (outerradius > radius)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("outer radius cannot be less or equal to radius");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error in outer entering radius");
                    }
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

            ring = new RING(radius, x, y, outerradius);
            Console.WriteLine($"Ring length = {ring.Ring_length}");
            Console.WriteLine($"Area ring = {ring.Area_ring}");
        }
    }
}
