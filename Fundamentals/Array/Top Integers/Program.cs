using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool isItBigger = true;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
