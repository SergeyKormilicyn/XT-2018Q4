using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.REGULAREXPRESSIONS.EMAILFINDER
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("enter a string with email addresses");
            string text = Console.ReadLine();
            string regstr = @"\b[\w\.-]+@[\w\.-]+\.\w{2,6}\b";
            var regex = new Regex(regstr);
            var match = regex.Matches(text);

            if (match.Count > 0)
            {
                Console.WriteLine("managed to find the following addresses");
                foreach (var item in match)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("email addresses not found");
            }
        }
    }
}
