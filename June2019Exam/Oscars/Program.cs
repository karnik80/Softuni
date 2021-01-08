using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double point = double.Parse(Console.ReadLine());

                double calculatedPoints = (name.Length * point) / 2;
                points += calculatedPoints;

                if(points > 1250.5)
                {
                    break;
                }
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - points):F1} more!");
            }
        }
    }
}
