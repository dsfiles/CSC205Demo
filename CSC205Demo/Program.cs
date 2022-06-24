using System;
using System.Collections.Generic;
namespace CSC205Week08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            salmons.Remove("coho");
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }
    }
}
