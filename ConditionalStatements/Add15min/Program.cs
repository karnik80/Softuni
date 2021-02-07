using System;

namespace Add15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourIn = int.Parse(Console.ReadLine());
            int minutesIn = int.Parse(Console.ReadLine());

            int minutes = 0;
            int hour = 0;

            minutes = minutesIn + 15;
            hour = hourIn;

            if(minutes >= 60)
            {
                hour++;
                minutes = minutes - 60;
            }

            if(hour >= 24)
            {
                hour = 0;
            }

            if(minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }

        }
    }
}
