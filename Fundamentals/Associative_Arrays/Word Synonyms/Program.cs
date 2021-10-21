﻿using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> myWords = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (myWords.ContainsKey(word))
                {
                    myWords[word].Add(synonym);
                }
                else
                {
                    myWords.Add(word, new List<string>());
                    myWords[word].Add(synonym);
                }
            }

            foreach (var item in myWords)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
