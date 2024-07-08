public class Program
{
    static void Main() {
        //int i = 1;
        //while (i <= 6)
        //{
        //    System.Console.Write(5 * i + " ");
        //    i++;
        //}
        //System.Console.WriteLine();
        WriteMultiples(5);
    }
    static void WriteMultiples(int n) {
        int i = 1;
        while (i <= 6)
        {
            System.Console.Write(n * i + " ");
            i++;
        }
        System.Console.WriteLine();
    }
}
