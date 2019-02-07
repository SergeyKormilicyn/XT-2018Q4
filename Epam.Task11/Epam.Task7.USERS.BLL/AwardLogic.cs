using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.BLL.Interface;
using Epam.Task7.USERS.DAL.Interface;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao awarddao;

        public AwardLogic(IAwardDao awardDao)
        {
            this.awarddao = awardDao;
        }

        public void AddAward(Award award)
        {
            this.awarddao.AddAward(award);
        }

        public string GetAll()
        {
            return this.awarddao.GetAll();
        }

        public void AddAwardForUser(int idaward, int iduser)
        {
            this.awarddao.AddAwardForUser(idaward, iduser);
        }
    }
}
