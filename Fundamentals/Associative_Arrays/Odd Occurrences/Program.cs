using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> wordOccure = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string temp = word.ToLower();
                if (wordOccure.ContainsKey(temp))
                {
                    wordOccure[temp]++;
                }
                else
                {
                    wordOccure.Add(temp, 1);
                }
            }

            foreach (var word in wordOccure)
            {
                if(word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
