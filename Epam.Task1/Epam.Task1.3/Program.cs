using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._3
{
    class Program
    {
        public static void SQUARE(int n)
        {
            int counter_strok=1;
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    i = 0;
                    counter_strok++;
                    Console.WriteLine("");
                }
                if (counter_strok > n)
                {
                    break;
                }
                if (!((counter_strok - 1 == n / 2) & (i == (n / 2))))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter an odd number more than 0");

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0 & n % 2 !=0)
                    {
                        SQUARE(n);
                        break;
                    }
                    else
                    {
                        throw new Exception("Not this, enter an odd number more than 0");
                    }

                }
                catch
                {
                    Console.WriteLine("Not this, enter an odd number more than 0");
                }
            }
        }
    }
}
