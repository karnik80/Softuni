using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i + 1; j < input.Length; j++)
                {
                    int temp = input[i] + input[j];

                    if (magicNum == temp)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
            }
        }
    }
}
