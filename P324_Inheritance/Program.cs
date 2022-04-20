using System;
using System.Text;

namespace P324_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string normal = toCapitalized("bU tasKI metHodla yAzmAliSiz");
            //Console.WriteLine(normal);
            //Console.WriteLine("bU tasKI metHodla yAzmAliSiz");

            //Student student = new Student("Elshan","Aliyev","P324",78,false);

            //Student student1 = new Student();

            //student1.Name = "x";
            //student1.Surname = "y";
            //student1.Group = "g";
            //student1.Point = 10;
            //student1.isGraduated = true;

            //Console.WriteLine(student.Fullname());

            //student.getInfo();
            //student.ExamChance();

            //Student student = new Student();

            Student student = new Student("Elshan", "Aliyev", "P324", 78, false);
            //Console.WriteLine(student.Fullname());



            Doctor doctor = new Doctor("Seymur", "Manafov", "Baku Clinic","8");

            //doctor.Code = "";
            doctor.Code = "98a76j";
            Console.WriteLine(doctor.Code);
            //Console.WriteLine(doctor.getCode());

            //doctor.setCode("98asd9812");

            //Console.WriteLine(doctor.setCode("9kk9a"));
            //Console.WriteLine(doctor.Fullname());
            //doctor.Age = 5;
            //doctor.Code = "1c90a";
            //Console.WriteLine(doctor.Code);

            //Teacher teacher = new Teacher("Javid","Asadullayev","Programming",12500.52);

            //Console.WriteLine(teacher.Fullname());

            //Person person = new Person();





        }


        public static string toCapitalized(string sentence)
        {
            //string newStr = "";
            StringBuilder stringBuilder = new StringBuilder();
            sentence = sentence.ToLower();
            string[] words = sentence.Split();

            foreach (string word in words)
            {
                stringBuilder.Append(char.ToUpper(word[0]));
                for (int i = 1; i < word.Length; i++)
                {
                    stringBuilder.Append(word[i]);
                }
                if(word != words[words.Length - 1])
                {
                    stringBuilder.Append(" ");
                }
            }

            return stringBuilder.ToString();


        }
    }
}
