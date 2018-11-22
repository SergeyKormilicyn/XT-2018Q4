using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                {
                    summ += i;
                }
            }
            Console.WriteLine($"the sum of numbers is less than 1000 multiples 3 and 5 = {summ}");
        }
    }
}
