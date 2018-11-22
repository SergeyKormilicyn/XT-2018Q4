using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AVERAGE_STRING_LENGTH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str_array;
            int sum = 0;

            Console.WriteLine("enter the string");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsPunctuation(sb[i]))
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }
            str_array = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str_array.Length; i++)
            {
                sum += str_array[i].Length;
            }
            Console.WriteLine($"average word length = {(double)sum / str_array.Length}");
        }
    }
}
