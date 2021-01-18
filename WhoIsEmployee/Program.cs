using System;

namespace WhoIsEmployee
{
    class Program
    {
        private static readonly string format = "First name: {0}\nMiddle name: {1}\nLast name: {2}";

        static void Main(string[] args)
        {
            Employee[] department = new Employee[2];

            department[0] = new Employee("Ivan", "Fedorov", "Petrenko",
                35, Gender.MALE, "At home", "Admin", 2f, 35000f);

            department[1] = new Employee("Vasya", "Dmitriev", "Vasenko",
                40, Gender.MALE, "Office", "CEO", 8, 50000);

            Console.Out.WriteLine(department[0]);
            Console.Out.WriteLine(department[1]);
            Console.Out.WriteLine("Total: " + Employee.Total);
        }
    }

    class Employee
    {
        public static uint Total { get; private set; }

        private string firstName;
        private string middleName;
        private string lastName;

        private uint age;
        private Gender gender;

        private string workplace;
        private string position;
        private float expirience;
        private float salary;


        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        public Employee(string firstName, string middleName, string lastName, uint age, Gender gender, string workplace,
            string position, float expirience, float salary)
        {
            Total++;

            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.workplace = workplace;
            this.position = position;
            this.expirience = expirience;
            this.salary = salary;
        }

        public Employee()
        {
            Total++;
        }

        ~Employee()
        {
            Total--;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string MiddleName
        {
            get => middleName;
            set => middleName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public uint Age
        {
            get => age;
            set => age = value;
        }

        public string Workplace
        {
            get => workplace;
            set => workplace = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public float Expirience
        {
            get => expirience;
            set => expirience = value;
        }

        public float Salary
        {
            get => salary;
            set => salary = value;
        }

        protected bool Equals(Employee other)
        {
            return firstName == other.firstName && middleName == other.middleName && lastName == other.lastName &&
                   age == other.age && workplace == other.workplace && position == other.position &&
                   expirience.Equals(other.expirience) && salary.Equals(other.salary);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Employee) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(firstName, middleName, lastName, age, workplace, position, expirience, salary);
        }

        public override string ToString()
        {
            return $"First name: {firstName}\n" +
                   $"Middle name: {middleName}\n" +
                   $"Last name: {lastName}\n" +
                   $"Age: {age}\n" +
                   $"Gender: {gender}\n" +
                   $"Workplace: {workplace}\n" +
                   $"Position: {Position}\n" +
                   $"Experience: {expirience}\n" +
                   $"Salary: {salary}";
        }
    }

    enum Gender
    {
        MALE,
        FEMALE
    }
}