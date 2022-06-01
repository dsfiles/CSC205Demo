public class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 6)
        {
            WriteMultiples(i);
            i++;
        }
    }
    static void WriteMultiples(int n)
    {
        int j = 1;
        while (j <= 6)
        {
            System.Console.Write(n * j + "\t");
            j++;
        }
        System.Console.WriteLine();
    }

}
