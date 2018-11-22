using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random ran = new Random();
            int variable;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(0,100);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        variable = array[i];
                        array[i] = array[j];
                        array[j] = variable;
                    }
                }
            }
            Console.WriteLine("random sorted array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"minimal array element = {array[0]}");
            Console.WriteLine($"minimal array element = { array[9]}");
        }
    }
}
