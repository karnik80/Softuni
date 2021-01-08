using System;

namespace Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double total = 0.0;

            switch (destination)
            {
                case "Dubai":
                    if(season == "Winter")
                    {
                        total = days * 45000.00;
                    }
                    else if(season == "Summer")
                    {
                        total = days * 40000.00;
                    }
                    total = total * 0.7;
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        total = days * 17000.00;
                    }
                    else if (season == "Summer")
                    {
                        total = days * 12500.00;
                    }
                    total = total * 1.25;
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        total = days * 24000.00;
                    }
                    else if (season == "Summer")
                    {
                        total = days * 20250.00;
                    }
                    break;
            }
            double diff = budget - total;
            if(diff >= 0)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {diff:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(diff):F2} leva more!");
            }
        }
    }
}
