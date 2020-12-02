using System;

namespace _2K1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int x = 1;

            while(x <= number)
            {
                Console.WriteLine(x);
                x = (x * 2) + 1;
            }
        }
    }
}
