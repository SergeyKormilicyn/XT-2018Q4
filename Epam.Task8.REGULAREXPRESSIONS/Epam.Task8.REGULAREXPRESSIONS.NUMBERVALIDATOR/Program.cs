using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.REGULAREXPRESSIONS.NUMBERVALIDATOR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            string text = Console.ReadLine();
            string regstrusual = @"^[-]?[0-9]*\.?,?[0-9]+$";
            string regstrscience = @"-?[\d.]+(?:e-?\d+)?";
            var regexusual = new Regex(regstrusual, RegexOptions.IgnoreCase);
            var regexuscience = new Regex(regstrscience, RegexOptions.IgnoreCase);
            if (regexusual.IsMatch(text))
            {
                Console.WriteLine("this number is in usual notation.");
            }
            else if (regexuscience.IsMatch(text))
            {
                Console.WriteLine("this number is in scientific notation.");
            }
            else
            {
                Console.WriteLine("this is not number");
            }
        }
    }
}
