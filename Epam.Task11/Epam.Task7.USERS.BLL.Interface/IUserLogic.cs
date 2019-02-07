﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.USERS.Entities;

namespace Epam.Task7.USERS.BLL.Interface
{
    public interface IUserLogic
    {
        void Add(User user);

        void Delete(int id);

        string GetAll();

        string ShowAwards(int id);
    }
}
