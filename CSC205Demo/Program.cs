namespace CSC205Quiz06
{
    public class Rect
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public static double ComputeArea1(Rect rec)
        {
            return rec.Height * rec.Length;
        }
        public double ComputeArea2()
        {
            return Height * Length;
        }
    }
    public class Program
    {
        public static void Main()
        {
            // Create a new Rect object call r using the default constructor
            // Invoke ComputeArea1 and display the area of r 
            // set both r's Height and Length to 3;
            // Invoke ComputeArea2 to display the area of r
            //Answers:
            var r = new Rect();
            System.Console.WriteLine(Rect.ComputeArea1(r));
            r.Height = r.Length = 3.0;
            System.Console.WriteLine(r.ComputeArea2());

        }
    }
}