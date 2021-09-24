using System;

namespace Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double pricePerDay = 0.0;
            double priceTotal = 0.0;

            for (int day = 1; day <= days; day++)
            {
                pricePerDay = 0.0;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if((day % 2 == 0) && (hour % 2 != 0))
                    {
                        pricePerDay += 2.50;
                    }
                    else if((day % 2 != 0)&&(hour % 2 == 0))
                    {
                        pricePerDay += 1.25;
                    }
                    else
                    {
                        pricePerDay += 1.00;
                    }
                }
                priceTotal += pricePerDay;
                Console.WriteLine($"Day: {day} - {pricePerDay:F2} leva");
            }
            Console.WriteLine($"Total: {priceTotal:F2} leva");
        }
    }
}
