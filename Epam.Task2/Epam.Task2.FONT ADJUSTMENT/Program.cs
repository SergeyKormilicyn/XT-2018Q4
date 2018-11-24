using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FONT_ADJUSTMENT
{
    class Program
    {
        [Flags]
        enum text_formatting : byte
        {
            none = 0,
            bold = 1,
            italic = 2,
            underline = 4,
        }
        static text_formatting curecurrent_text_status = text_formatting.none;

        public static void current_state()
        {
            Console.Write("label parameters: ");
            Console.Write(curecurrent_text_status + Environment.NewLine);
            Console.WriteLine("1: " + text_formatting.bold + Environment.NewLine + "2: " + text_formatting.italic + Environment.NewLine + "3: " + text_formatting.underline);
        }

        public static void change_state(int n)
        {
            n = Convert.ToInt32(Math.Pow(2, n - 1));
            if (curecurrent_text_status.HasFlag((text_formatting)n))
            {
                curecurrent_text_status &= ~(text_formatting)n;
            }
            else
            {
                curecurrent_text_status |= (text_formatting)n;
            }
        }
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                current_state();
                Console.WriteLine("enter the number of the label which you want to add or delete");
                if (Int32.TryParse(Console.ReadLine(), out n) & n <= 3 & n > 0)
                {
                    change_state(n);
                }
                else
                {
                    Console.WriteLine("error in entering number of label");
                }
            }
        }
    }
}