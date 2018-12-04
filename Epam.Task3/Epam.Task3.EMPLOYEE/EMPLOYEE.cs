using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.EMPLOYEE
{
    public class EMPLOYEE : USER.USER
    {
        private int workexperience;
        private string position;

        public EMPLOYEE(string lastName, string firstName, string patronymic, DateTime dateofBirth, int age, int workexperience, string position)
        
            : base(lastName, firstName, patronymic, dateofBirth, age)
        {
            if (workexperience < 0)
            {
                throw new Exception("experience can not be negative");
            }

            this.workexperience = workexperience;
            this.position = position;
        }

        public new string Getfullinf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Getfullinf());
            sb.Append(this.workexperience).Append(" ");
            sb.Append(this.position);
            return sb.ToString();
        }
    }
}
