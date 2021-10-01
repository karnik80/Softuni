using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            Dictionary<char, int> myLetters = new Dictionary<char, int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] != ' ')
                {
                    if (myLetters.ContainsKey(sentence[i]))
                    {
                        myLetters[sentence[i]]++;
                    }
                    else
                    {
                        myLetters.Add(sentence[i], 1);
                    }
                }
            }

            foreach (var item in myLetters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
