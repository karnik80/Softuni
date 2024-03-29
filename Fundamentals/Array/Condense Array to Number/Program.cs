﻿using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] temp = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    temp[i] = array[i] + array[i + 1];
                }
                array = temp;
            }
            Console.WriteLine(array[0]);
        }
    }
}
