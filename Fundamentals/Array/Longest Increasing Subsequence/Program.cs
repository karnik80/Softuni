using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j <= i - 1; j++)
                {
                    if(numbers[j] < numbers[i] && len[j] + 1 > len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }

                if(len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            Console.WriteLine(string.Join(" ", RestoreLIS(numbers, prev, lastIndex)));
        }

        static int[] RestoreLIS(int[] numbers, int[] prev, int lastindex)
        {
            List<int> longest = new List<int>();
            while(lastindex != -1)
            {
                longest.Add(numbers[lastindex]);
                lastindex = prev[lastindex];
            }

            longest.Reverse();
            return longest.ToArray();
        }
    }
}
