using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTarget = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double totalSeconds = meters * secondsPerMeter;
            double delay = Math.Floor(meters / 50) * 30;
            totalSeconds = totalSeconds + delay;

            double difference = recordTarget - totalSeconds;
            if(difference <= 0)
            {
                Console.WriteLine($"No! He was {Math.Abs(difference):F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totalSeconds:F2} seconds.");
            }
        }
    }
}
