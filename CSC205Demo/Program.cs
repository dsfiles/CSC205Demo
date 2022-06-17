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
