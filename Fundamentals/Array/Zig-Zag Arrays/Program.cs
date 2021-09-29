﻿using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arr1[i] = temp[1];
                    arr2[i] = temp[0];
                }
                else
                {
                    arr1[i] = temp[0];
                    arr2[i] = temp[1];
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
        }
    }
}
