using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Inheritance
{
    class Teacher:Person
    {
        //public string Name;
        //public string Surname;
        public string Profession;
        public double Salary;

        public Teacher(string name, string surname, string profession, double salary):base(name,surname)
        {
            Name = name;
            Surname = surname;
            Profession = profession;
            Salary = salary;
        }

        //public string Fullname()
        //{
        //    return $"{Name} {Surname}";
        //}
    }
}
