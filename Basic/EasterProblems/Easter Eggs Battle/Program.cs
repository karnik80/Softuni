using System;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End of battle")
                {
                    Console.WriteLine($"Player one has {player1} eggs left.");
                    Console.WriteLine($"Player two has {player2} eggs left.");
                    break;
                }

                if(input == "one")
                {
                    player2--;
                    if(player2 <= 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {player1} eggs left.");
                        break;
                    }
                }
                else if(input == "two")
                {
                    player1--;
                    if(player1 <= 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {player2} eggs left.");
                        break;
                    }
                }
            }
        }
    }
}
