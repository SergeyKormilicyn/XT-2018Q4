using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.REGULAREXPRESSIONS.TIMECOUNTER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string with time");
            string text = Console.ReadLine();
            string regstr = @"\s+([01]?[0-9]|2[0-3]):[0-5][0-9]";
            var regex = new Regex(regstr, RegexOptions.IgnoreCase);
            Console.WriteLine($"time met in the text {regex.Matches(text).Count} times");
        }
    }
}
