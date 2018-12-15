using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ISEEKYOU
{
   public class Program
    {
        public delegate bool Sumelement(int element);

        public static int Sumnonegativeelement(int[] array)
        {
            int sum = 0;

            foreach (var item in array)
            {
                if (item >= 0)
                {
                    sum += item;
                }
            }

            return sum;
        }

        public static int Sumnonegativeelement(int[] array, Sumelement compare)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (compare(item))
                {
                    sum += item;
                }
            }  

            return sum;
        }

        public static bool Nonegativeelement(int element)
        {
            if (element >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public static void Main(string[] args)
        {
            int step = 100;
            List<long> time = new List<long>();
            Stopwatch sw = new Stopwatch();
            Random rnd = new Random();
            int[] array = new int[500];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }

            for (int i = 0; i < step; i++)
            {
                sw.Start();
                Sumnonegativeelement(array);
                time.Add(sw.ElapsedTicks);
                sw.Reset();
            }

            Console.WriteLine("Time method 1 = " + time.Average());
            time.Clear();

            for (int i = 0; i < step; i++)
            {
                sw.Start();
                Sumnonegativeelement(array, Nonegativeelement);
                time.Add(sw.ElapsedTicks);
                sw.Reset();
            }

            Console.WriteLine("Time method 2 = " + time.Average());
            time.Clear();

            for (int i = 0; i < step; i++)
            {
                sw.Start();
                var result = Sumnonegativeelement(
                    array, 
                    delegate(int element)
                {
                    if (element >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
                time.Add(sw.ElapsedTicks);
                sw.Reset();
            }

            Console.WriteLine("Time method 3 = " + time.Average());
            time.Clear();

            for (int i = 0; i < step; i++)
            {
                sw.Start();
                Sumnonegativeelement(array, element => element > -1);
                time.Add(sw.ElapsedTicks);
                sw.Reset();
            }

            Console.WriteLine("Time method 4 = " + time.Average());
            time.Clear();

            for (int i = 0; i < step; i++)
            {
                sw.Start();
                int result = array.Where(j => j > -1).Sum();
                time.Add(sw.ElapsedTicks);
                sw.Reset();
            }

            Console.WriteLine("Time method 5 = " + time.Average());
            time.Clear();
        }
    }
}
