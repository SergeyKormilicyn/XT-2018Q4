using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.BLL;
using Epam.Task7.USERS.BLL.Interface;
using Epam.Task7.USERS.DAL;
using Epam.Task7.USERS.DAL.Interface;

namespace Epam.Task7.USERS.Common
{
    public static class DependencyResolver
    {
        private static IUserDao userdao;

        private static IAwardLogic awardlogic;

        private static IUserLogic userLogic;

        private static IAwardDao awarddao;

        public static IUserDao Userdao => userdao ?? (userdao = new UserDao());

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(Userdao));

        public static IAwardDao Awarddao => awarddao ?? (awarddao = new AwardDao());

        public static IAwardLogic Awardlogic => awardlogic ?? (awardlogic = new AwardLogic(Awarddao));
    }
}
