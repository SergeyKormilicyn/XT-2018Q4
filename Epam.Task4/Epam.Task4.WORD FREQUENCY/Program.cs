using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.WORD_FREQUENCY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str;
            string[] strarray;
            char[] separator = { ' ', '.' };
            int k = 0;
            List<string> words = new List<string>();

            Console.WriteLine("enter text in English");
            str = Console.ReadLine().ToLower();
            strarray = str.Split(separator);

            foreach (var item in strarray)
            {
                if (!item.Equals(string.Empty))
                {
                    words.Add(item);
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i; j < words.Count; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        k++;
                    }

                    if (k > 1 & words[i].Equals(words[j]))
                    {
                        words.RemoveAt(j);
                        j--;
                    }
                }

                Console.WriteLine(words[i] + " = " + k);
                k = 0;
            }
        }
    }
}
