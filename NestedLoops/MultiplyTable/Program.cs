using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiply1 = 0;
            int multiply2 = 0;
            int result;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
        }
    }
}
