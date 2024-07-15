﻿using System;
namespace ThinkSharp{
    public class Program {
        public static void Main(string[] args) {
            int[] scores = RandomArray(30);
            WriteArray(scores);
            int[] counts = new int[100];
            for (int i = 0; i < scores.Length; i++) {
                int index = scores[i];
                counts[index]++;
            }
            WriteArray(counts);
        }
        public static int[] RandomArray(int size) {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++) {
                array[i] = random.Next(0, 100);
            }
            return array;
        }
        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
