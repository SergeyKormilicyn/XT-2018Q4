using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.USER
{
    public class USER
    {
        private string lastName;
        private string firstName;
        private string patronymic;
        private DateTime dateofBirth;
        private int age;

        public USER(string lastName, string firstName, string patronymic, DateTime dateofBirth, int age)
        {
            if ((int)(DateTime.Now.Year - dateofBirth.Year) != age)
            {
                throw new Exception("such age cannot with such date of birth");
            }

            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.dateofBirth = dateofBirth;
            this.age = age;
        }

        public string Getfullinf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.lastName).Append(" ");
            sb.Append(this.firstName).Append(" ");
            sb.Append(this.patronymic).Append(" ");
            sb.Append(this.dateofBirth.ToString("dd.MM.yyyy")).Append(" ");
            sb.Append(this.age).Append(" ");
            return sb.ToString();
        }
    }
}
