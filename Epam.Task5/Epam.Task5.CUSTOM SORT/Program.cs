using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.CUSTOM_SORT
{
    public class Program
    {
        public delegate int Comparison<T>(T first, T second);

        public static void Sort<T>(T[] a, Comparison<T> compare)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (compare(a[i], a[j]) > 0)
                    {
                        var temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public static int Compareint(int first, int second)
        {
            if (first > second)
            {
                return 1;
            }

            if (first == second)
            {
                return 0;
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] array = { 15, 7, -5, 6, 4 };
            Console.WriteLine("enter an unsorted array");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("apply our method and output an array");
            Sort(array, Compareint);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
