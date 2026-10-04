using System;
using System.Collections.Generic;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public int StudentId;

    public Student(string name, int studentId)
        : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Student ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary;

    public Employee(string name, double salary)
        : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName;

    public Teacher(string name, string courseName)
        : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Course Name: " + CourseName);
    }
}

class Program
{
    static void ShowPerson(Person person)
    {
        person.DisplayInfo();
    }

    static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Student("Ahmed", 101));
        people.Add(new Employee("Ali", 5000));
        people.Add(new Teacher("Mohammed", "Programming"));

        foreach (Person person in people)
        {
            Console.WriteLine("Runtime Type: " + person.GetType().Name);
            person.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Using ShowPerson method:");
        ShowPerson(people[0]);
    }
}
