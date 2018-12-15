using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.NUMBER_ARRAY_SUM
{
   public static class Program
    {
        public static int NUMBERARRAYSUM(this int[] array)
        {
            int sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int[] array = { 15, 7, -5, 6, 4 };
            int sum;

            Console.WriteLine("enter an array");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("apply our widening method and output a sum");
            sum = NUMBERARRAYSUM(array);
            Console.WriteLine(sum);
        }
    }
}
