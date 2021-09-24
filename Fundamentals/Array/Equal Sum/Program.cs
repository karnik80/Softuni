using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqual = false;
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //int test = input[i];
                int[] first = new int[i];
                int[] second = new int[input.Length - 1 - i];
                for (int j = 0; j < first.Length; j++)
                {
                    first[j] = input[j];
                }
                for (int k = 0; k < second.Length; k++)
                {
                    second[k] = input[k + 1 + i];
                }

                int leftSum = 0;
                leftSum = first.Sum();
                int rightSum = 0;
                rightSum = second.Sum();

                if (leftSum == rightSum)
                {
                    isEqual = true;
                    index = i;
                    break;
                }
            }

            if (isEqual == true)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
