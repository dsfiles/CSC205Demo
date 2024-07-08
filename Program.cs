public class Program {
    static void Main() {
        WriteTable(6, 6);
    }
    static void WriteTable(int m, int n)
    {
        int i = 1;
        while (i <= m)
        {
            for (int j = 1; j <= n; j++)
            {
                System.Console.Write(j * i + " ");
            }
            System.Console.WriteLine();
            i = i + 1;
        }
    }
}
