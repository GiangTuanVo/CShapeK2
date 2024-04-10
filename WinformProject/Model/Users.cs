using System;
using System.Collections.Generic;

namespace WinformProject.Model
{
    public class Users
    {
        public string Name;
        public int Age;
        public string Sex;
        public DateTime BirthDay;
        public List<Users> GetUsers = new List<Users>();
        public Users()
        {
        }
        public Users(string name, int age, string sex, DateTime birthday)
        {
            Name = name;
            Age = age;
            Sex = sex;
            BirthDay = birthday;
        }

        public override string ToString()
        {
            return $"{Name},{Age},{Sex},{BirthDay}\r\n";
        }
    }
}
