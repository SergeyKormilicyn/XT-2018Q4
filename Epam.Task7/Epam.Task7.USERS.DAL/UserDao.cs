using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.DAL.Interface;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.DAL
{
    public class UserDao : IUserDao
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory + "users.txt";

        public void Add(User user)
        {
            int k = 0;
            StreamWriter output = new StreamWriter(path, true);
            output.Close();

            StreamReader input = new StreamReader(path);
            string str = input.ReadToEnd();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[0].Equals('1') & i == 0)
                {
                    k++;
                }

                if (i == str.Length - 1)
                {
                    break;
                }

                if (str[i].Equals((char)13) & str[i + 1].Equals((char)10))
                {
                    k++;
                }
            }

            input.Close();
            output = new StreamWriter(path, true);
            user.Id = k;
            output.WriteLine(user.ToString());
            output.Close();
        }

        public void Delete(int id)
        {
            StreamWriter output = new StreamWriter(path, true);
            output.Close();
            StreamReader input = new StreamReader(path);
            
            string str = input.ReadToEnd();
            input.Close();
            int k = 0;
            int firstchar = -1;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                {
                    break;
                }

                if (str[i].Equals((char)13) & str[i + 1].Equals((char)10))
                {
                    if (id == 0)
                    {
                        str = str.Remove(0, i);
                        str = str.Insert(0, "delete");
                        break;
                    }

                    k++;
                    if (firstchar >= 0)
                    {
                        str = str.Remove(firstchar, i - firstchar);
                        str = str.Insert(firstchar, "\r" + "\n" + "delete");
                        break;
                    }

                    if (k == id)
                    {
                        firstchar = i;
                    }
                }
            }

            output = new StreamWriter(path, false);
            output.Write(str);
            output.Close();
        }
        
        public string GetAll()
        {
            StreamWriter output = new StreamWriter(path, true);
            output.Close();
            StreamReader input = new StreamReader(path);

            string str = input.ReadToEnd();
            input.Close();
            return str;
        }

        public string ShowAwards(int id)
        {
            string pathusersandawards = AppDomain.CurrentDomain.BaseDirectory + "usersandawards.txt";
            StreamReader input = new StreamReader(pathusersandawards);
            string str = input.ReadToEnd();
            string idfromfile = string.Empty;
            input.Close();
            string awards = string.Empty;
            AwardDao awarddao = new AwardDao();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[0] + string.Empty).Equals(id.ToString()) & i == 0)
                {
                    awards = awarddao.GetById(int.Parse(str[i + 2] + string.Empty)) + " ";
                }

                if (i == str.Length - 2)
                {
                    break;
                }

                if (str[i].Equals((char)13) & str[i + 1].Equals((char)10))
                {
                    idfromfile = str[i + 2] + string.Empty;
                    if (idfromfile.Equals(id.ToString()))
                    {
                        awards += awarddao.GetById(int.Parse(str[i + 4] + string.Empty)) + " ";
                    }
                }
            }

            return awards;
        }
    }
}
