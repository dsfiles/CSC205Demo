//Question 1

using System;
using System.Collections.Generic;
class Doubloon

{
    static bool IsDoubloon(string s)
    {

        IDictionary<char, int> doubloon = new Dictionary<char, int>();
        // sets result to true by default
        bool result = true;
        // converts string to all lowercase values so characters can be properly evaluated
        s = s.ToLower();
        // for loop iterates through each letter of the string
        foreach (char c in s)
        {
            // if the letter is already a key in the dictionary, add one to tally
            if (doubloon.ContainsKey(c))
            {
                doubloon[c]++;
            }

            // if the letter is not yet a key in the dictionary, add the key/value pair with the value set to one
            else
            {
                doubloon.Add(c, 1);
            }
        }



        //iterates throguh dictionary, checking if all characters in string ('keys') appeared exactly twice

        // if any characters appeared more or less than twice, the result is changed to false

        foreach (char key in doubloon.Keys)

        {

            if (doubloon[key] != 2)

            {

                result = false;

            }

        }



        return result;

    }

    static void Main(string[] args)

    {

        Console.WriteLine(IsDoubloon("Appeases"));

        Console.WriteLine(IsDoubloon("Appeasesa"));

    }

}