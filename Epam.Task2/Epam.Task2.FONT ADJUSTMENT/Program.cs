using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FONT_ADJUSTMENT
{
    class Program
    {
        enum text_formatting
        {
            bold,
            italic,
            underline,
        }
        static bool[] selected_fonts = new bool[3];

        public static void current_state()
        {
            bool chek_none = false;
            Console.Write("label parameters: ");
            for (int i = 0; i < selected_fonts.Length; i++)
            {
                if (selected_fonts[i])
                {
                    Console.Write((text_formatting)i + " ");
                    chek_none = true;
                }
            }
            if (!chek_none)
            {
                Console.Write("None");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("1: " + text_formatting.bold + Environment.NewLine + "2: " + text_formatting.italic + Environment.NewLine + "3: " + text_formatting.underline);
        }

        public static void change_state(int n)
        {
            if (selected_fonts[n])
            {
                selected_fonts[n] = false;
            }
            else
            {
                selected_fonts[n] = true;
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
                    change_state(n - 1);
                }
                else
                {
                    Console.WriteLine("error in entering number of label");
                }
            }
        }
    }
}
