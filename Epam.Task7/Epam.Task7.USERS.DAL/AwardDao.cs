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
    public class AwardDao : IAwardDao
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory + "awards.txt";
        private static string pathusersandawards = AppDomain.CurrentDomain.BaseDirectory + "usersandawards.txt";

        public void AddAward(Award award)
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
            award.Id = k;
            output.WriteLine(award.ToString());
            output.Close();
        }

        public void Delete(int id)
        {
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

            StreamWriter output = new StreamWriter(path, false);
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

        public void AddAwardForUser(int iduser, int idaward)
        {
            StreamWriter output = new StreamWriter(pathusersandawards, true);

            output.WriteLine(iduser + " " + idaward);
            output.Close();
        }

        public string GetById(int id)
        {
            StreamWriter output = new StreamWriter(path, true);
            output.Close();
            StreamReader input = new StreamReader(path);
            string str = input.ReadToEnd();
            string[] delid;
            input.Close();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[0] + string.Empty).Equals(id.ToString()) & i == 0)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j].Equals((char)13) & str[j + 1].Equals((char)10))
                        {
                            str = str.Remove(j, str.Length - j);
                            delid = str.Split(' ');
                            str = delid[1];
                            return str;
                        }
                    }
                }

                if (i == str.Length - 2)
                {
                    break;
                }

                string idfromfile = str[i + 2] + string.Empty;

                if (str[i].Equals((char)13) & str[i + 1].Equals((char)10))
                {
                    if (idfromfile.Equals(id.ToString()))
                    {
                        for (int j = i + 2; j < str.Length; j++)
                        {
                            if (str[j].Equals((char)13) & str[j + 1].Equals((char)10))
                            {
                                str = str.Remove(j, str.Length - j);
                                delid = str.Split(' ');
                                str = delid[delid.Length - 1];
                                return str;
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
