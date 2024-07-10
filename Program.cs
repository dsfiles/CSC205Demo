// code example from textbook page 169
using System;
using System.IO;
namespace ThinkSharp
{
    public class ListFile
    {
        public static void Main()
        { //make sure words.txt is in the same folder as the .exe file
            processFile("words.txt");
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
