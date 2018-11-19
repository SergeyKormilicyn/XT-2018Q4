using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._2
{
    class Program
    {
        public static void SIMPLE(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("the number is not simple");
                    return;
                }
            }
            Console.WriteLine("the number is simple");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number more than 0");

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        SIMPLE(n);
                        break;
                    }
                    else
                    {
                        throw new Exception("Not this, enter a number more than 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Not this, enter a number more than 0");
                }
            }
        }
    }
}
