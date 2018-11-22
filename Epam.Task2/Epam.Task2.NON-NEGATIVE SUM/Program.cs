using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random ran = new Random();
            int sum = 0;

            Console.WriteLine("Random array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(-100, 100);
                Console.WriteLine(array[i]);
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum of non-negative elements = {sum}");
        }
    }
}
