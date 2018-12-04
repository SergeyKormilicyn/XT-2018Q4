using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VECTOR_GRAPHICS_EDITOR
{
    public class Program
    {
       public static void Main(string[] args)
        {
            LINE line;
            CIRCUMFERENCE circumference;
            double radiusforcircumference;
            double radius2forcircumference;
            RECTANGLE rectangle;
            double asideforrectangle;
            double bsideforrectangle;
            ROUND.ROUND round;
            double radiusforround;
            RING.RING ring;
            double radiusforring;
            double outerradiusforring;
            Random rnd = new Random();

            Console.WriteLine("create a line with an random parameter \"x\" and \"y\"");
            line = new LINE(rnd.NextDouble(), rnd.NextDouble());
            Console.WriteLine("the object we created has the following parameters");
            Console.WriteLine(line.ToString());
            Console.WriteLine($"x = {line.X}");
            Console.WriteLine($"y = {line.Y}" + Environment.NewLine);

            Console.WriteLine("create a circumference with an random parameter \"x\" and \"y\"");
            Console.WriteLine("enter a first radius more than or equal to 0");
            if (double.TryParse(Console.ReadLine(), out radiusforcircumference) & radiusforcircumference >= 0)
            {
                Console.WriteLine("enter a second radius more than or equal to 0");
                if (double.TryParse(Console.ReadLine(), out radius2forcircumference) & radius2forcircumference >= 0)
                {
                    circumference = new CIRCUMFERENCE(radiusforcircumference, rnd.NextDouble(), rnd.NextDouble(), radius2forcircumference);
                    Console.WriteLine("the object we created has the following parameters");
                    Console.WriteLine(circumference.ToString());
                    Console.WriteLine($"first radius = {circumference.Radius}");
                    Console.WriteLine($"second radius= {circumference.Radiustwo}");
                    Console.WriteLine($"x = {circumference.X}");
                    Console.WriteLine($"y = {circumference.Y}" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("error in second entering radius" + Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("error in first entering radius" + Environment.NewLine);
            }

            Console.WriteLine("create a rectangle with an random parameter\"x\" and \"y\"");
            Console.WriteLine("enter a first side \"a\" more than  0");
            if (double.TryParse(Console.ReadLine(), out asideforrectangle) & asideforrectangle > 0)
            {
                Console.WriteLine("enter a second side \"b\" more than  0");
                if (double.TryParse(Console.ReadLine(), out bsideforrectangle) & bsideforrectangle > 0)
                {
                    rectangle = new RECTANGLE(asideforrectangle, bsideforrectangle, rnd.NextDouble(), rnd.NextDouble());
                    Console.WriteLine("the object we created has the following parameters");
                    Console.WriteLine(rectangle.ToString());
                    Console.WriteLine($"first side \"a\" = {rectangle.A}");
                    Console.WriteLine($"second side \"b\"= {rectangle.B}");
                    Console.WriteLine($"x = {rectangle.X}");
                    Console.WriteLine($"y = {rectangle.Y}" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("error in second entering side \"b\"" + Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("error in first entering side \"a\"" + Environment.NewLine);
            }

            Console.WriteLine("create a round with an random parameter \"x\" and \"y\"");
            if (double.TryParse(Console.ReadLine(), out radiusforround) & radiusforround >= 0)
            {
                Console.WriteLine("enter a radius more than or equal to 0");
                round = new ROUND.ROUND(radiusforround, rnd.NextDouble(), rnd.NextDouble());
                Console.WriteLine("the object we created has the following parameters");
                Console.WriteLine(round.ToString());
                Console.WriteLine($"radius = {round.Radius}");
                Console.WriteLine($"x = {round.X}");
                Console.WriteLine($"y = {round.Y}" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("error in entering radius" + Environment.NewLine);
            }

            Console.WriteLine("create a ring with an random parameter \"x\" and \"y\"");
            Console.WriteLine("enter a radius more than or equal to 0");
            if (double.TryParse(Console.ReadLine(), out radiusforring) & radiusforring >= 0)
            {
                Console.WriteLine("enter a outer radius more than or equal to 0");
                if (double.TryParse(Console.ReadLine(), out outerradiusforring) & outerradiusforring >= 0)
                {
                    if (outerradiusforring > radiusforring)
                    {
                        ring = new RING.RING(radiusforring, rnd.NextDouble(), rnd.NextDouble(), outerradiusforring);
                        Console.WriteLine("the object we created has the following parameters");
                        Console.WriteLine(ring.ToString());
                        Console.WriteLine($"radius = {ring.Radius}");
                        Console.WriteLine($"outer radius = {ring.Outer_radius}");
                        Console.WriteLine($"x = {ring.X}");
                        Console.WriteLine($"y = {ring.Y}");
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
    }
}
