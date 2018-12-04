using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.USER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            USER user;
            string lastName;
            string firstName;
            string patronymic;
            DateTime dateofBirth;
            int age;

            Console.WriteLine("enter a last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("enter a first Name");
            firstName = Console.ReadLine();
            Console.WriteLine("enter a patronymic");
            patronymic = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("enter date as in example 21.05.2015");
                if (DateTime.TryParse(Console.ReadLine(), out dateofBirth))
                {
                    Console.WriteLine("enter a age");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        if ((int)(DateTime.Now.Year - dateofBirth.Year) == age)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("such age cannot with such date of birth");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error in entering age");
                    }
                }
                else
                {
                    Console.WriteLine("error in entering date");
                }
            }
            
            user = new USER(lastName, firstName, patronymic, dateofBirth, age);
            Console.WriteLine(user.Getfullinf());
        }
    }
}
