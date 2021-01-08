using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int seasonNumber = int.Parse(Console.ReadLine());
            int seriesNumber = int.Parse(Console.ReadLine());
            double timeMinutes = double.Parse(Console.ReadLine());

            double totalMinutes = ((timeMinutes * 1.2) * seriesNumber * seasonNumber) + (seasonNumber * 10);

            Console.WriteLine($"Total time needed to watch the {movieName} series is {totalMinutes} minutes.");
        }
    }
}
