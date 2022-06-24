public class App
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        System.Console.WriteLine( Banana(arr));

    }
    // Answer: computes the sum of array a's elements and returns it.
    public static int Banana(int[] a)
    {
        int grape = 0;
        int i = 0;
        while (i < a.Length)
        {
            grape = grape + a[i];
            i++;
        }
        return grape;
    }
}