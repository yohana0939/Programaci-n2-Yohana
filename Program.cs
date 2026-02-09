using System;
using classmap;

//Name of Student: Yohana Montero
//ID: 2025-0939
//Seccion: Saturday 9 a 1

namespace classmap
{
   
    public class Communitymember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Communitymember(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Email: {Email}");
        }
    }

  
    public class Employee : Communitymember
    {
        public string Position { get; set; }

        public Employee(string name, int age, string email, string position)
            : base(name, age, email)
        {
            Position = position;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Position: {Position}");
        }
    }

    public class Student : Communitymember
    {
        public string Career { get; set; }

        public Student(string name, int age, string email, string career)
            : base(name, age, email)
        {
            Career = career;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Career: {Career}");
        }
    }

    public class ExStudent : Communitymember
    {
        public int GraduationYear { get; set; }

        public ExStudent(string name, int age, string email, int graduationYear)
            : base(name, age, email)
        {
            GraduationYear = graduationYear;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Graduation Year: {GraduationYear}");
        }
    }

  
    public class Teacher : Employee
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string email, string position, string subject)
            : base(name, age, email, position)
        {
            Subject = subject;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    public class Administrative : Employee
    {
        public string Department { get; set; }

        public Administrative(string name, int age, string email, string position, string department)
            : base(name, age, email, position)
        {
            Department = department;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Department: {Department}");
        }
    }

    



    public class Administrator : Teacher
    {
        public string AdministrationArea { get; set; }

        public Administrator(string name, int age, string email, string position, string subject, string administrationArea)
            : base(name, age, email, position, subject)
        {
            AdministrationArea = administrationArea;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Administration Area: {AdministrationArea}");
        }
    }

    public class Master : Teacher
    {
        public int YearsExperience { get; set; }

        public Master(string name, int age, string email, string position, string subject, int yearsExperience)
            : base(name, age, email, position, subject)
        {
            YearsExperience = yearsExperience;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Years of Experience: {YearsExperience}");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Communitymember member =
                new Communitymember("Yohana Montero", 21, "yohanamontero@gmail.com");
            member.ShowInformation();
            Console.WriteLine();

            Employee employee =
                new Employee("Brayan Montero", 24, "brayan@email.com", "Systems Engineer");
            employee.ShowInformation();
            Console.WriteLine();

            Teacher teacher =
                new Teacher("Ana Perez", 35, "ana@email.com", "Teacher", "Mathematics");
            teacher.ShowInformation();
            Console.WriteLine();

            Administrative adminStaff =
                new Administrative("Carlos Montero", 40, "carlos@email.com", "Administrative Staff", "Finance");
            adminStaff.ShowInformation();
            Console.WriteLine();

            Administrator administrator =
                new Administrator("Jose Montero", 45, "jose@email.com", "Director", "Management", "Academic Affairs");
            administrator.ShowInformation();
            Console.WriteLine();

            Master master =
                new Master("Pedro Montero", 50, "pedro@email.com", "Senior Teacher", "Physics", 20);
            master.ShowInformation();
            Console.WriteLine();

            Student student =
                new Student("Elizabeth Montero", 20, "elizabeth@email.com", "Software Development");
            student.ShowInformation();
            Console.WriteLine();

            ExStudent exStudent =
                new ExStudent("Maria Lopez", 28, "maria@email.com", 2022);
            exStudent.ShowInformation();

            Console.ReadKey();
        }
    }
}
