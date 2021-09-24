using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shift = int.Parse(Console.ReadLine());

            int[] temp = new int[input.Length];

            for (int j = 0; j < shift; j++)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    temp[i] = input[i + 1];
                }
                temp[input.Length - 1] = input[0];

                for (int k = 0; k < temp.Length; k++)
                {
                    input[k] = temp[k];
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
