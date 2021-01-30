using System;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int totalMinutes = minutesPerWalk * walksPerDay;
            int burnedCalories = totalMinutes * 5;

            if((caloriesPerDay/2) <= burnedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else if((caloriesPerDay / 2) > burnedCalories)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
