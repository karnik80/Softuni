using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;

            while(volume >= 0)
            {
                string input = Console.ReadLine();

                if(input == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }

                int boxes = int.Parse(input);
                volume -= boxes;
            }
            if(volume <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
