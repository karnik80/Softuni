using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(array.Length % 2 == 0)
            {
                int[] first = array.Take(array.Length / 2).ToArray();
                int[] second = array.TakeLast(array.Length / 2).ToArray();

                Array.Reverse(first);
                Array.Reverse(second);

                int[] temp = new int[array.Length];

                Array.Copy(first, 0, temp, 0, first.Length);
                Array.Copy(second, 0, temp, temp.Length / 2, second.Length);

                for (int i = array.Length / 4; i < ((array.Length / 2)+(array.Length / 4)); i++)
                {
                    int temporal = 0;
                    temporal = array[i] + temp[i];
                    Console.Write($"{temporal} ");
                }
            }
        }
    }
}
