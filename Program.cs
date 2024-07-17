// version 2
public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Allan", 21);
        Teacher teacher = new Teacher("Tom", 55, "Computer Science");
        teacher.DisplayNameAge();
        Student student = new Student("Sara", 19, 3.5);
        student.DisplayNameAge();
    }
}

class Person // Parent class
{
    public string name;
    public int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void DisplayNameAge()
    { System.Console.WriteLine($"{name} is {age} years old."); }
}
class Teacher : Person
{ // Child class 
    public string subject;
    public Teacher(string name, int age, string subject) : base(name, age)
    { this.subject = subject; }
}
class Student : Person
{ // Child class
    public double gpa;
    public Student(string name, int age, double gpa) : base(name, age)
    { this.gpa = gpa; }
}
