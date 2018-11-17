using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1._1
{ 
    class Program
    {
        public static string SEQUENCE(int n)
        {
            string for_output;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if (i != n)
                {
                    sb.Append(", ");
                }
            }
            return for_output = sb.ToString();
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
           Console.WriteLine(SEQUENCE(n));
            Console.ReadLine();
        }
    }
}
