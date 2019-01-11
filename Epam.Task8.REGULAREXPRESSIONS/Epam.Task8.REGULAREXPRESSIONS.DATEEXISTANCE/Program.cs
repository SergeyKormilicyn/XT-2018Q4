using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.REGULAREXPRESSIONS.DATEEXISTANCE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string with date");
            string text = Console.ReadLine();
            string regstr = "(0[1-9]|[12][0-9]|3[01])[-](0[1-9]|1[012])[-](19|20)[0-9]{2}";
            var regex = new Regex(regstr, RegexOptions.IgnoreCase);
            Console.WriteLine("in a string there is a date. " + regex.IsMatch(text));
        }
    }
}
