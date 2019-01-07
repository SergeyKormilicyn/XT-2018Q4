using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.DAL.Interface
{
    public interface IAwardDao
    {
        void AddAward(Award award);

        string GetAll();

        void AddAwardForUser(int idaward, int iduser);
    }
}
