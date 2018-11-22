using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CHAR_DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chek_doubl = false;

            Console.WriteLine("Enter the first line:");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter the second line:");
            StringBuilder sb1 = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < sb1.Length; i++)
            {
                chek_doubl = false;
                for (int j = 0; j < sb.Length; j++)
                {
                    if (sb1[i].ToString().ToUpper().Equals(sb[j].ToString().ToUpper()))
                    {
                        sb.Insert(j, sb1[i]);
                        j++;
                        chek_doubl = true;
                    }
                }
                if (chek_doubl)
                {
                    sb1.Replace(sb1[i].ToString(), "");
                    i = -1;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
