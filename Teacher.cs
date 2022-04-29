using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherManager tichManager = new TeacherManager();
            Teacher teacher = tichManager.Create("Misak --", "Sahakyan --", 38);
            Teacher[] teachers = tichManager.Create(10, 18, 30);
            tichManager.Print(teacher);
            tichManager.Print(teachers);

            //Delay...
            Console.ReadKey();
        }
    }

    public class TeacherManager
    {
        public Teacher Create(string firstname, string secondname, int age)
                => new Teacher(firstname, secondname, age);
        public Teacher[] Create(int count, int minAge, int maxAge)
        {
            Teacher[] teachert = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachert.Length; i++)
            {
                teachert[i] = new Teacher($"Firstname{i}", $"Secondname{i}", rnd.Next(minAge, maxAge));
            }

            return teachert;
        }

        public void Print(Teacher teacher)
        {
            Console.WriteLine($"firstName {teacher._firstName} secondName {teacher._secondName} age {teacher._age} ");
        }
        public void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"{teachers[i]._firstName} {teachers[i]._secondName} age {teachers[i]._age}");
            }
        }
    }
    public class Teacher
    {
        public Teacher(string firstName, string secondName, int age)
        {
            _firstName = firstName;
            _secondName = secondName;
            _age = age;
        }
        public string _firstName;
        public string _secondName;
        public int _age;
    }
}
