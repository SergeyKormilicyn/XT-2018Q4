using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.CUSTOMSORTDEMO
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

        public static int Comparestring(string first, string second)
        {
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if ((int)first[i] > (int)second[i])
                    {
                        return 1;
                    }

                    if ((int)first[i] < (int)second[i])
                    {
                        return -1;
                    }
                }

                return 0;
            }

            if (first.Length > second.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static void Main(string[] args)
        {
            string[] array = { "vova", "ekaterina", "vafelnica", "kica", "ribalovIvan" };
            Console.WriteLine("enter an unsorted array");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("apply our method and output an array");
            Sort(array, Comparestring);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
