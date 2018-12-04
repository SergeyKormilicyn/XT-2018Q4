using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MY_STRING
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MYSTRING str = new MYSTRING("hello");
            char chr;
            char chrtwo;
            int index;
            int indextwo;
            string[] array;

            Console.WriteLine("create an instance of the MYSTRING class with the \"hello\" parameter");
            Console.WriteLine("enter the words with which to compare it");
            Console.WriteLine(str.Mycompare(Console.ReadLine()));

            Console.WriteLine("enter the words that you want to add to our class");
            Console.WriteLine(str.Myconcat(Console.ReadLine()));

            Console.WriteLine("enter the character the number of the first entry of which you want to see if such a character in \"hello\" is not displayed on the screen -1");
            if (char.TryParse(Console.ReadLine(), out chr))
            {
                Console.WriteLine(str.Myindexof(chr));
            }
            else
            {
                Console.WriteLine("character is incorrect");
            }

            Console.WriteLine("enter the character the number of the last entry of which you want to see if such a character in \"hello\" is not displayed on the screen -1");
            if (char.TryParse(Console.ReadLine(), out chr))
            {
                Console.WriteLine(str.Mylastindexof(chr));
            }
            else
            {
                Console.WriteLine("character is incorrect");
            }

            Console.WriteLine("enter the number of the character you want to remove from \"hello\"");
            if (int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine(str.Myremove(index));
            }
            else
            {
                Console.WriteLine("number is incorrect");
            }

            Console.WriteLine("enter the number of character from which you want to remove from \"hello\"");
            if (int.TryParse(Console.ReadLine(), out index) & index >= 0)
            {
                Console.WriteLine("enter the number of character to which you want to remove from \"hello\"");
                if (int.TryParse(Console.ReadLine(), out indextwo) & indextwo > index)
                {
                    Console.WriteLine(str.Myremove(index, indextwo));
                }
                else
                {
                    Console.WriteLine("number is incorrect");
                }
            }
            else
            {
                Console.WriteLine("number is incorrect");
            }

            Console.WriteLine("create an instance of the MYSTRING class with the \"say hello to my little friend\" parameter");
            str = new MYSTRING("say hello to my little friend");
            Console.WriteLine("enter the character you want to share the phrase \"say hello to my little friend\"");
            if (char.TryParse(Console.ReadLine(), out chr))
            {
                array = str.Mysplit(chr);
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("character is incorrect");
            }

            Console.WriteLine("create an instance of the MYSTRING class with the \" hello world \" parameter");
            str = new MYSTRING(" hello world ");
            Console.WriteLine("use the trim function without parameters");
            Console.WriteLine(str.Mytrim());

            Console.WriteLine("create an instance of the MYSTRING class with the \"hello world\" parameter");
            str = new MYSTRING("hello world");
            Console.WriteLine("enter the first character that you do not want to see on the edges of \"hello world\"");
            if (char.TryParse(Console.ReadLine(), out chr))
            {
                Console.WriteLine("enter the second character that you do not want to see on the edges of \"hello world\"");
                if (char.TryParse(Console.ReadLine(), out chrtwo))
                {
                    Console.WriteLine(str.Mytrim(chr, chrtwo));
                }
                else
                {
                    Console.WriteLine("character is incorrect");
                }
            }
            else
            {
                Console.WriteLine("character is incorrect");
            }

            Console.WriteLine("create an instance of the MYSTRING class with the \"hello world\" parameter");
            Console.WriteLine("enter the number from which you want to cut the string \"hello world\"");
            if (int.TryParse(Console.ReadLine(), out index) & index >= 0)
            {
                Console.WriteLine(str.Mysubstring(index));
            }
            else
            {
                Console.WriteLine("number is incorrect");
            }

            Console.WriteLine("enter the number of the character from which you want to insert the string in \"hello world\"");
            if (int.TryParse(Console.ReadLine(), out index) & index >= 0)
            {
                Console.WriteLine("enter the string you want to insert in \"hello world\"");
                Console.WriteLine(str.Myinsert(index, Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("number is incorrect");
            }
        }
    }
}
