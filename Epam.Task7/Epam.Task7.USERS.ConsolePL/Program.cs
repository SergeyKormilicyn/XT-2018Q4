using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.BLL;
using Epam.Task7.USERS.BLL.Interface;
using Epam.Task7.USERS.Common;
using Epam.Task7.USERS.DAL;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var award = new Award
            {
                Title = "zolupa"
            };
            string input;
            var userLogic = DependencyResolver.UserLogic;
            var awardlogic = DependencyResolver.Awardlogic;

            while (true)
            {
                Console.WriteLine("write \"addu\" or \"delu\" or \"showu\" to add or delete or show a user");
                Console.WriteLine("write \"adda\" or \"showa\"  to add or show a award/s");
                Console.WriteLine("write \"addau\" or \"showau\"  to add award to user or show a user awards");
                input = Console.ReadLine();
                if (input.Equals("addu"))
                {
                    AddUser(userLogic);
                }
                else if (input.Equals("delu"))
                {
                    DeleteUser(userLogic);
                }
                else if (input.Equals("showu"))
                {
                    Console.WriteLine("Id | Name | Date Of Birth | Age");
                    Console.WriteLine(userLogic.GetAll());
                }
                else if (input.Equals("adda"))
                {
                    AddAward(awardlogic);
                }
                else if (input.Equals("showa"))
                {
                    Console.WriteLine("current awards");
                    Console.WriteLine(awardlogic.GetAll());
                }
                else if (input.Equals("addau"))
                {
                    AddAwardForUser(awardlogic);
                }
                else if (input.Equals("showau"))
                {
                    ShowUserAwards(userLogic);
                }
                else
                {
                    Console.WriteLine("error in the entered string, enter \"add\" or \"del\"");
                }
            }
        }

        private static void AddUser(IUserLogic userlogic)
        {
        string name;
        int age;
            Console.WriteLine("Enter a name");
            name = Console.ReadLine();
            Console.WriteLine("Enter a age more 4");
            if (!(int.TryParse(Console.ReadLine(), out age) & age > 4))
            {
                Console.WriteLine("date entry error");
                return;
            }

            Console.WriteLine("the date will be selected current");
            var user = new User
            {
                Name = name,
                DateOfBirth = DateTime.Now,
                Age = age,
            };
            userlogic.Add(user);
        }

        private static void DeleteUser(IUserLogic userlogic)
        {
            int id;

            Console.WriteLine("enter the ID of the user you want to delete");
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("id entry error");
            }

            userlogic.Delete(id);
        }

        private static void AddAward(IAwardLogic awardlogic)
        {
            string name;
            Console.WriteLine("Enter a name of award");
            name = Console.ReadLine();
            var award = new Award
            {
                Title = name
            };
            awardlogic.AddAward(award);
        }

        private static void AddAwardForUser(IAwardLogic awardlogic)
        {
            int iduser;
            int idaward;
            Console.WriteLine("enter the user ID to which you want to add a award");
            if (!int.TryParse(Console.ReadLine(), out iduser))
            {
                Console.WriteLine("date entry user ID");
                return;
            }

            Console.WriteLine("enter the award ID to which you want to add");
            if (!int.TryParse(Console.ReadLine(), out idaward))
            {
                Console.WriteLine("date entry award ID");
                return;
            }

            awardlogic.AddAwardForUser(iduser, idaward);
        }

        private static void ShowUserAwards(IUserLogic userlogic)
        {
            int id;

            Console.WriteLine("enter the ID of the user you want to show awards");

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("id entry error");
            }

            Console.WriteLine("This user has the following awards.");
            Console.WriteLine(userlogic.ShowAwards(id));
        }
    }
}
