using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int pieces = width * lenght;
            string input = Console.ReadLine();

            while(input != "STOP")
            {

                int piece = int.Parse(input);
                pieces -= piece;

                if (pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");               
            }
        }
    }
}
