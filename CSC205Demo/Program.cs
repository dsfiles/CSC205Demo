using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    public class quiz5
    {
        public static bool IsDoubloon(string word)
        {
            word = word.ToLower();
            for (int counter = 0; counter < word.Length; counter++)
            {
                int matchCount = 0;
                char c = word[counter];
                for (int compare = 0; compare < word.Length; compare++)
                {
                    if (c == word[compare])
                    {
                        matchCount = matchCount + 1;
                    }
                }
                if (matchCount != 2)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.WriteLine(IsDoubloon("bilabial"));
            Console.WriteLine(IsDoubloon("Shanghaiings"));
        }
    }
}