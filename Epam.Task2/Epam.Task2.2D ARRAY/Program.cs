using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random ran = new Random();
            int sum = 0;

            Console.WriteLine("Random array");
            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1)+1; j++)
                {
                    array[i, j] = ran.Next(-100, 100);
                    Console.Write(array[i, j] + " ");
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine($"the sum of the position numbers of the array in both even dimensions = {sum}");
        }
    }
}
