using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int shootingTime = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double remainingTime = shootingTime - (shootingTime * 0.15);
            double sceneRequiredTime = scenes * sceneTime;
            double leftTime = remainingTime - sceneRequiredTime;

            if (leftTime >= 0)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(leftTime)} minutes left!");
            }
            else
            {
                leftTime = Math.Abs(leftTime);
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(leftTime)} minutes.");
            }
        }
    }
}
