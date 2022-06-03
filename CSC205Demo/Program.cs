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
        }

        private static void processFile(string filename)
        {
            string line;
            int count = 1;
            TextReader reader = new StreamReader(filename);
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(count + ": " + line);
                count++;
            }
            reader.Close();
        }
    }
}
