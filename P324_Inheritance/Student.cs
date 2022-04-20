using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Inheritance
{
    class Student:Person
    {
        //public string Name;
        //public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;


        public Student()
        {
            Console.WriteLine("3cu constructor");
        }
        public Student(string Name, string Surname,string group, byte point, bool isgraduated):base(Name,Surname)//:this(group)
        {
            if(Group != null)
            {
                //this.Name = Name;
                //this.Surname = Surname;

                Point = point;
                isGraduated = isgraduated;
                Console.WriteLine("1ci constructor");
            }
            else
            {
                Console.WriteLine("Student yarana bilmedi");
            }
            
        }

       

        //public Student(string group) : this()
        //{
        //    if(group.Length > 3)
        //    {
        //        Group = group;
        //        Console.WriteLine("2ci constructor");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Qrup adi minimum 3 xarakterden ibaret olamlidir");
        //    }
        //}



        //public string Fullname()
        //{
        //    return $"Name: {Name}, Surname: {Surname}";
        //}

        public void getInfo()
        {
            //if (isGraduated)
            //{
            //    Console.WriteLine($"Name: {Name}, Surname: {Surname} Group: {Group} Point: {Point} => Mezun olub");
            //}
            //else
            //{
            //    Console.WriteLine($"Name: {Name}, Surname: {Surname} Group: {Group} Point: {Point} => Mezun olmayib");
            //}

            //Shorthand if
            Console.WriteLine($"Name: {Name}, Surname: {Surname} Group: {Group} Point: {Point} => {(isGraduated ? "Mezun olub" : "Mezun olmayib")}");
        }

        public void ExamChance()
        {
            Console.WriteLine($"{(Point > 80 ? $"Bu telebenin bali {Point}-dir. Buna gore 2ci imtahana gire biler" : $"Bu telebenin bali {Point}-dir. Buna gore imtahana gire bilmez")}");
        }
    }
}
