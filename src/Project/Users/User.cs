﻿namespace Users
{
    public class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }


        public object IsOfLegalAge()
        {
            return true;
        }


    }
}