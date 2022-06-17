abstract class Person
{ // Parent class
    public string name;
    public int age;
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
    public string subject;
    public Teacher(string name, int age, string subject) : base(name, age)
    { this.subject = subject; }
    public void DisplayTeacher()
    {
        base.DisplayNameAge();
        System.Console.WriteLine($"Teaches {subject}\n");
    }
}
class Student : Person
{ // Child class
    public double gpa;
    public Student(string name, int age, double gpa) : base(name, age)
    { this.gpa = gpa; }
    public void DisplayStudent()
    {
        base.DisplayNameAge();
        System.Console.WriteLine($"GPA: {this.gpa}");
    }
}
