using System;

namespace SwimRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double lenghtMeters = double.Parse(Console.ReadLine());
            double secondPerMeter = double.Parse(Console.ReadLine());

            double secondsForDistance = lenghtMeters * secondPerMeter;
            double additionalTimeCount = Math.Floor(lenghtMeters/15.0);
            double additionalTime = additionalTimeCount * 12.5;

            double totalTime = secondsForDistance + additionalTime;

            if(totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime-worldRecord:F2} seconds slower.");
            }
        }
    }
}
