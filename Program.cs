using System;
public class Person // parent class
{
    public string name;
    public int age;
    public void DisplayNameAge()
    {
        Console.WriteLine($"{name} is {age} years old.");
    }
}

class Teacher : Person // Child class
{
    public string subject;
}

class Student : Person // Child class
{
    public double gpa;
}

public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Allan";
        person.age = 21;

        Teacher teacher = new Teacher();
        teacher.name = "Tom";
        teacher.age = 55;
        teacher.subject = "Computer Science";
        teacher.DisplayNameAge();

        Student student = new Student();
        student.name = "Sara";
        student.age = 19;
        student.gpa = 3.5;
        student.DisplayNameAge();
    }
}
