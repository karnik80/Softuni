using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double boatRent = 0.0;

            if(season == "Spring")
            {
                boatRent = 3000.00;
                if(fishermans <= 6)
                {
                    boatRent = boatRent * 0.9;               
                }
                else if(fishermans >= 7 && fishermans <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if(fishermans >= 12)
                {
                    boatRent = boatRent * 0.75;
                }
            }
            else if(season == "Summer" || season == "Autumn")
            {
                boatRent = 4200.00;
                if (fishermans <= 6)
                {
                    boatRent = boatRent * 0.9;
                }
                else if (fishermans >= 7 && fishermans <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if (fishermans >= 12)
                {
                    boatRent = boatRent * 0.75;
                }
            }
            else if(season == "Winter")
            {
                boatRent = 2600.00;
                if (fishermans <= 6)
                {
                    boatRent = boatRent * 0.9;
                }
                else if (fishermans >= 7 && fishermans <= 11)
                {
                    boatRent = boatRent * 0.85;
                }
                else if (fishermans >= 12)
                {
                    boatRent = boatRent * 0.75;
                }
            }
            else
            {

            }
            
            if(season != "Autumn")
            {
                if(fishermans % 2 == 0)
                {
                    boatRent = boatRent * 0.95;
                }
            }

            if((budget-boatRent) >= 0)
            {
                Console.WriteLine($"Yes! You have {(budget - boatRent):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - boatRent):F2} leva.");
            }
        }
    }
}
