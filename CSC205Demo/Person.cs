abstract class Person
{ // Parent class
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void DisplayNameAge()
    { System.Console.WriteLine($"Name：{name}, Age: {age}"); }
}
class Teacher : Person
{ // Child class
    private string subject;
    public Teacher(string name, int age, string subject) : base(name, age)
    { this.subject = subject; }
    public void DisplayInfo()
    {
        base.DisplayNameAge();
        System.Console.WriteLine($"Teaches {subject}\n");
    }
}
class Student : Person
{ // Child class
    private double gpa;
    public double Gpa { 
        get { return gpa; } 
        set { gpa = value; } 
    } // Just a Property example
    public Student(string name, int age, double gpa) : base(name, age)
    { this.gpa = 3.5; }
    public void DisplayInfo()
    {
        base.DisplayNameAge();
        System.Console.WriteLine($"GPA: {this.gpa}");
    }
}