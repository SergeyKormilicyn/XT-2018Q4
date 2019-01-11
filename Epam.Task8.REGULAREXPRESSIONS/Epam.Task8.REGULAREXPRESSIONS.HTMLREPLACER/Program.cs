using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.REGULAREXPRESSIONS.HTMLREPLACER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string with HTML tegs");
            string text = Console.ReadLine();
            string regstr = @"<[^>]*>";
            var regex = new Regex(regstr, RegexOptions.IgnoreCase);
            Console.WriteLine("The result of the replacement:" + regex.Replace(text, "_"));
        }
    }
}
