using System;

namespace WritingClassFor6Hours
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var student = new Student();
            student.Age = 15;
            student.Name = "Vasya Pupkin";
            student.Grade = 4.69f;

            student.print();
        }
    }

    class Student
    {
        private string name;
        private int age;
        private float grade;

        public Student()
        {
        }

        public Student(string name, int age, float grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public Student(Student student)
        {
            name = student.name;
            age = student.age;
            grade = student.grade;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public float Grade
        {
            get => grade;
            set => grade = value;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age + "\n Grade" + grade);
        }
    }
}