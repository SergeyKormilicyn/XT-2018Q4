using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._1
{ 
    class Program
    {
        public static void SEQUENCE(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (i != n)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number more than 0");

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        SEQUENCE(n);
                        break;
                    }
                    else
                    {
                        throw new Exception("Not this, enter a number more than 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Not this, enter a number more than 0");
                }
            }
        }
    }
}
