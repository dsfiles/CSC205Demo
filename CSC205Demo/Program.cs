using System;
class CSC205Week04ExerciseThree {
    public static void Main(){
        int i = 0;
        double e = 0;
        while (i < 10)
        {
            e += 1.0 / F(i);
            i++;
        }
        Console.WriteLine(Math.E-e);
    }
    public static long F(int n){
        if (n == 0)
            return 1;
        long product = 1;
        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }
        return product;
    }
}