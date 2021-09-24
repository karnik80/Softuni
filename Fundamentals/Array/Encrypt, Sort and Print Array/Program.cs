using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] encrypted = new int[n];

            string vowels = "AaEeIiOoUu";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sumVowels = 0;
                int sumConsonant = 0;

                for (int j = 0; j < input.Length; j++)
                {
                        if (vowels.Contains(input[j]) == true)
                        {
                            sumVowels += (int)input[j] * input.Length;
                        }
                        else
                        {
                            sumConsonant += (int)input[j] / input.Length;
                        }
                }

                encrypted[i] = sumVowels + sumConsonant;
            }

            Array.Sort(encrypted);

            foreach (var item in encrypted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
