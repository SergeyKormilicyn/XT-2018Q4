using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.SORTING_UNIT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SORTINGUNIT ty = new SORTINGUNIT();
            int[] array = { 15, 7, -5, 6, 4 };
            Console.WriteLine("enter an unsorted array");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("apply our method and output an array");

            ty.Already += ty.Conclusion;
            ty.Sortflow(array, ty.Compareint);
            while (true)
            {
                if (!ty.Th.IsAlive)
                {
                    break;
                }

                Console.WriteLine("wait another flow...");
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
