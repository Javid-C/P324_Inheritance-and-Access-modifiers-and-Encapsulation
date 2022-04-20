using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Inheritance
{
    class Person
    {
        public string Name;
        public string Surname;


        public Person()
        {

        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Fullname()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
}
