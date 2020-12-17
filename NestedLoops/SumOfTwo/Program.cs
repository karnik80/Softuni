using System;

namespace SumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            bool done = false;

            for (int st = start; st <= end; st++)
            {
                for (int st1 = start; st1 <= end; st1++)
                {
                    combination++;
                    if((st+st1) == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({st} + {st1} = {magicNumber})");
                        done = true;
                        break;
                    }
                }
                if(done == true)
                {
                    break;
                }
            }
            if(done != true)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
