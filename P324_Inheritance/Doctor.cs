using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Inheritance
{
    class Doctor : Person
    {
        //public string Name;
        //public string Surname;
        public string Hospital;
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (value.Length > 5)
                {
                    _code = value;
                }
                else
                {
                    Console.WriteLine("Code-nin uzunlugu minimum 6 olmalidir");
                }
            }
        }

        private string _code;

        public Doctor(string name, string surname, string hospital, string code) : base(name, surname)
        {
            Code = code;
            Name = name;
            Surname = surname;
            Hospital = hospital;
        }

        //public string getCode()
        //{
        //    return Code;
        //}

        //public void setCode(string code)
        //{
        //    if(code.Length > 5)
        //    {
        //        Code = code;
        //    }
        //    //return Code;
        //    Console.WriteLine(Code);
        //}

        //public string Fullname()
        //{
        //    return $"{Name} {Surname}";
        //}

    }
}
