using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.LOST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            bool chek = false;
            List<int> people = new List<int>();

            while (true)
            {
                Console.WriteLine("enter a number more than 0");
                if (int.TryParse(Console.ReadLine(), out n) & n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering number");
                }
            }

            for (int i = 1; i <= n; i++)
            {
                people.Add(i);
                Console.Write(people[i - 1] + " ");
            }

            Console.WriteLine();

            while (people.Count > 1)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (chek)
                    {
                        people.RemoveAt(i);
                        i--;
                    }

                    chek = !chek;
                }

                for (int j = 0; j < people.Count; j++)
                {
                    Console.Write(people[j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
