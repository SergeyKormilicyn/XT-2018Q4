using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.WriteLine("enter a number more than 0");
                if (Int32.TryParse(Console.ReadLine(), out n) & n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering number");
                }
            }
            for (int z = 0; z <= n; z++)
            {
                for (int i = 1; i <= z; i++)
                {
                    int j = i;
                    for (; n - j > 0; j++)
                    {
                        Console.Write(" ");
                    }
                    j = i + i - 1;
                    for (; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}
