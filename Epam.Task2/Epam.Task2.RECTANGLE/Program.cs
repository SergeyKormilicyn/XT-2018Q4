using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            while (true)
            {
                Console.WriteLine("enter a width more than 0 using the number");
                if (Int32.TryParse(Console.ReadLine(), out a) & a>0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering width");
                }
            }

            while (true)
            {
                Console.WriteLine("enter a length more than 0 using the number");
                if (Int32.TryParse(Console.ReadLine(), out b) & b > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering length");
                }
            }
            Console.WriteLine($"rectangle area = {a * b}");
        }
    }
}
