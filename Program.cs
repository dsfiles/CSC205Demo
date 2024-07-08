public class Program
{
    static void Main() {
        int i = 1;
        while (i <= 6) {
            WriteMultiples(i);
            i = i + 1;
        }
    }
    static void WriteMultiples(int n) {
        int i = 1;
        while (i <= 6) {
            System.Console.Write(n * i + " ");
            i++;
        }
        System.Console.WriteLine();
    }
}
