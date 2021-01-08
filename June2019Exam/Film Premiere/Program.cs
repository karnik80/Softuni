using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double total = 0.0;

            switch (movie)
            {
                case "John Wick":
                    switch (packet)
                    {
                        case "Drink":
                            total = tickets * 12.00;
                            break;
                        case "Popcorn":
                            total = tickets * 15.00;
                            break;
                        case "Menu":
                            total = tickets * 19.00;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (packet)
                    {
                        case "Drink":
                            total = tickets * 18.00;
                            break;
                        case "Popcorn":
                            total = tickets * 25.00;
                            break;
                        case "Menu":
                            total = tickets * 30.00;
                            break;
                    }
                    if(tickets >= 4)
                    {
                        total = total * 0.7;
                    }
                    break;
                case "Jumanji":
                    switch (packet)
                    {
                        case "Drink":
                            total = tickets * 9.00;
                            break;
                        case "Popcorn":
                            total = tickets * 11.00;
                            break;
                        case "Menu":
                            total = tickets * 14.00;
                            break;
                    }
                    if(tickets == 2)
                    {
                        total = total * 0.85;
                    }
                    break;
            }
            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}
