using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            string temp = string.Empty;

            for (int i = floors; i > 0; i--)
            {
                if(i == floors)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("L" + i + j + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    if(i % 2 == 0)
                    {
                        for (int j = 0; j < number; j++)
                        {
                            Console.Write("O" + i + j + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 0; j < number; j++)
                        {
                            Console.Write("A" + i + j + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
