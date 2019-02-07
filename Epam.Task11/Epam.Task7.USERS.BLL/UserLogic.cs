using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.BLL.Interface;
using Epam.Task7.USERS.DAL;
using Epam.Task7.USERS.DAL.Interface;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao userdao;

        public UserLogic(IUserDao userDao)
        {
            this.userdao = userDao;
        }

        public void Add(User user)
        {
            this.userdao.Add(user);
        }

        public void Delete(int id)
        {
            this.userdao.Delete(id);
        }

        public string GetAll()
        {
            return this.userdao.GetAll();
        }

        public string ShowAwards(int id)
        {
            return this.userdao.ShowAwards(id);
        }
    }
}
