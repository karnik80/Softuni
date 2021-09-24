using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x > maxNum)
                {
                    maxNum = x;
                }
                if(x < minNum)
                {
                    minNum = x;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
