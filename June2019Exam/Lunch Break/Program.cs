using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double lunchTime = breakDuration * (1.0 / 8);
            double breakTime = breakDuration * (1.0 / 4);
            double leftMinutes = breakDuration - (lunchTime + breakTime);

            if((leftMinutes-duration) >= 0)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(leftMinutes - duration)} minutes free time.");
            }
            else
            {
                double missingMinutes = Math.Abs(leftMinutes - duration);
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(missingMinutes)} more minutes.");
            }
        }
    }
}
