using System;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Name = name;
        Email = email;

        Console.WriteLine("Person constructor called");
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
    }
}

class Student : Person
{
    public int StudentId;
    public double GPA;

    public Student(string name, string email, int studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;

        Console.WriteLine("Student constructor called");
    }
}

class Employee : Person
{
    public int EmployeeId;
    public double Salary;

    public Employee(string name, string email, int employeeId, double salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;

        Console.WriteLine("Employee constructor called");
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, int employeeId,
                   double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;

        Console.WriteLine("Teacher constructor called");
    }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching " + CourseName);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Creating Student:");

        Student student = new Student(
            "Ahmed",
            "ahmed@email.com",
            101,
            3.5
        );

        Console.WriteLine();

        student.DisplayBasicInfo();
        Console.WriteLine("Student ID: " + student.StudentId);
        Console.WriteLine("GPA: " + student.GPA);

        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();

        Console.WriteLine("Creating Teacher:");

        Teacher teacher = new Teacher(
            "Mohammed",
            "mohammed@email.com",
            201,
            8000,
            "Programming"
        );

        Console.WriteLine();

        teacher.DisplayBasicInfo();
        Console.WriteLine("Employee ID: " + teacher.EmployeeId);
        Console.WriteLine("Salary: " + teacher.Salary);
        Console.WriteLine("Course Name: " + teacher.CourseName);

        teacher.Teach();
    }
}
