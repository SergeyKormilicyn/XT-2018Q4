using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.TOINTORNOTTOINT
{
    public static class Program
    {
        public static bool TOINTORNOTTOINT(this string str)
        {
            if (str[0].Equals('-'))
            {
                str = str.Remove(0, 1);
            }

            var pointcounter = str.Where(i => i == '.');
            if (str[0].Equals('.') | str[str.Length - 1].Equals('.') | pointcounter.Count() >= 2)
            {
                return false;
            }

            var ecounter = str.Where(i => i == 'e' | i == 'E');
            if (str[0].Equals('e') | str[str.Length - 1].Equals('e') | str[0].Equals('E') | str[str.Length - 1].Equals('E') | ecounter.Count() >= 2)
            {
                return false;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].Equals('e') | str[i].Equals('E'))
                {
                    if (str[i - 1].Equals('.') | str[i + 1].Equals('.'))
                    {
                        return false;
                    }

                    str = str.Remove(i, 1);
                    if (str[i].Equals('+'))
                    {
                        str = str.Remove(i, 1);
                        if (i == str.Length)
                        {
                            return false;
                        }
                    }
                }
            }

            bool result = str.All(char.IsDigit) | str.Any(i => i == '.');
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string to check for a number using a dot and not a comma for example 3.14E+06");
            string str = Console.ReadLine();
            Console.WriteLine("is string digit? " + str.TOINTORNOTTOINT());
        }
    }
}
