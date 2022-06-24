public class App
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 5 };
        //System.Console.WriteLine(Banana(arr));
        //System.Console.WriteLine(Apple(arr, 6));
        System.Console.WriteLine(Grapefruit(arr,1));
    }
    // Answer: computes the sum of array a's elements and returns it.
    public static int Banana(int[] a)
    {
        int sum = 0;
        int i = 0;
        while (i < a.Length)
        {
            sum = sum + a[i];
            i++;
        }
        return sum;
    }

    // Answer: counts the number of times that p appears in the array a
    public static int Apple(int[] a, int p)
    {
        int i = 0;
        int count = 0;
        while (i < a.Length)
        {
            if (a[i] == p)
            {
                count++;
            }
            i++;
        }
        return count;
    }

    // Answer: return the index of the first appearance of integer p in array a, or -1 if not found
    public static int Grapefruit(int[] a, int p)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == p) 
                return i;
        }
        return -1;
    }
}