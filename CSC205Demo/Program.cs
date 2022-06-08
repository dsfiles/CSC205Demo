using System;
using System.IO;

namespace ThinkSharp
{
    public class ListFile
    {
        public static void Main()
        {
            try
            {
                processFile("words.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("That didn't work. Here's why:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        } }

    }
}
