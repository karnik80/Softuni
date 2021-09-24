using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musala = 0;
            int montblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;
            int total = 0;

            for (int i = 0; i < groups; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number <= 5)
                {
                    musala += number;
                }
                else if(number >= 6 && number <= 12)
                {
                    montblan += number;
                }
                else if(number >= 13 && number <= 25)
                {
                    kilimandjaro += number;
                }
                else if(number >= 26 && number <= 40)
                {
                    k2 += number;
                }
                else if(number >= 41)
                {
                    everest += number;
                }
            }
            total = musala + montblan + kilimandjaro + k2 + everest;

            double musalaPercent = (musala * 1.0 / total) * 100;
            Console.WriteLine($"{musalaPercent:F2}%");

            double montblanPercent = (montblan * 1.0/ total) * 100;
            Console.WriteLine($"{montblanPercent:F2}%");

            double kilimandjaroPercent = (kilimandjaro * 1.0/ total) * 100;
            Console.WriteLine($"{kilimandjaroPercent:F2}%");

            double k2Percent = (k2 * 1.0/ total) * 100;
            Console.WriteLine($"{k2Percent:F2}%");

            double everestPercent = (everest * 1.0/ total) * 100;
            Console.WriteLine($"{everestPercent:F2}%");
        }
    }
}
