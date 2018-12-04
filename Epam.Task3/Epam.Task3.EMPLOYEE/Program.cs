using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.EMPLOYEE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EMPLOYEE employee;
            string lastName;
            string firstName;
            string patronymic;
            DateTime dateofBirth;
            int age;
            int workexperience;
            string position;

            Console.WriteLine("enter a last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("enter a first Name");
            firstName = Console.ReadLine();
            Console.WriteLine("enter a patronymic");
            patronymic = Console.ReadLine();
            Console.WriteLine("enter a work position");
            position = Console.ReadLine();

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

            while (true)
            {
                Console.WriteLine("enter a work experience");
                if (int.TryParse(Console.ReadLine(), out workexperience) & workexperience > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error in entering work experience");
                }
            }

            employee = new EMPLOYEE(lastName, firstName, patronymic, dateofBirth, age, workexperience, position);
            Console.WriteLine(employee.Getfullinf());
        }
    }
}
