using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.TRIANGLE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TRIANGLE triangle;
            double a;
            double b;
            double c;

            while (true)
            {
                Console.WriteLine("enter the first side of the triangle");
                if (double.TryParse(Console.ReadLine(), out a) & a >= 0)
                {
                    Console.WriteLine("enter the second side of the triangle");
                    if (double.TryParse(Console.ReadLine(), out b) & b >= 0)
                    {
                        Console.WriteLine("enter the  third side of the triangle");
                        if (double.TryParse(Console.ReadLine(), out c) & c >= 0)
                        {
                            if (a + b > c & a + c > b & b + c > a)
                            {
                                triangle = new TRIANGLE(a, b, c);
                                Console.WriteLine($" triangle area = {triangle.CalcArea()}");
                                Console.WriteLine($" triangle perimeter = {triangle.CalcPerimeter()}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("such a triangle does not exist");
                            }
                        }
                        else
                        {
                            Console.WriteLine("error in entering third side");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error in entering second side");
                    }
                }
                else
                {
                    Console.WriteLine("error in entering first side");
                }
            }
        }
    }
}
