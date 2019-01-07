using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.BLL.Interface
{
    public interface IAwardLogic
    {
        void AddAward(Award award);

        string GetAll();

        void AddAwardForUser(int idaward, int iduser);
    }
}
