using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._2
{
    class Program
    {
        public static bool SIMPLE(int n)
        {
            for (int i = 2; i < n/2; i++)
            {
                if (n % i==0)
                {
                    return true;   
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SIMPLE(n));
            Console.ReadLine();
        }
    }
}
