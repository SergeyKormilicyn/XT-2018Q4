using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._3
{
    class Program
    {
        public static string SQUARE(int n)
        {
            StringBuilder sb = new StringBuilder();
            int counter_strok=1;
            string for_output;
            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    i = 0;
                    counter_strok++;
                    sb.Append(Environment.NewLine);
                }
                if (counter_strok > n)
                {
                    break;
                }
                if (!((counter_strok - 1 == n / 2) & (i == (n / 2))))
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(" ");
                }
            }
            return for_output = sb.ToString();
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SQUARE(n));
            Console.ReadLine();
        }
    }
}
