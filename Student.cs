using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager stManager = new StudentManager();
            Student student = stManager.Create("Vaxo --", "Peres --", 38);
            Student[] students = stManager.Create(10, 18, 30);
            stManager.Print(student);
            stManager.Print(students);

            //Delay...
            Console.ReadKey();
        }
    }

    public class StudentManager
    {
        public Student Create(string firstname, string secondname, int age)
                => new Student(firstname, secondname, age);
        public Student[] Create(int count, int minAge, int maxAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"Firstname{i}", $"Secondname{i}", rnd.Next(minAge, maxAge));
            }

            return students;
        }

        public void Print(Student student)
        {
            Console.WriteLine($"firstName {student._firstName} secondName {student._secondName} age {student._age} ");
        }
        public void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]._firstName} {students[i]._secondName} age {students[i]._age}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string secondName, int age)
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
