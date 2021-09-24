using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int airlinesNumber = int.Parse(Console.ReadLine());

            double maxPass = 0.0;
            string airlineTop = string.Empty;

            for (int i = 0; i < airlinesNumber; i++)
            {
                int passTemp = 0;
                int count = 0;

                string airlineName = Console.ReadLine();

                while (true)
                {
                    string pass = Console.ReadLine();
                    if(pass == "Finish")
                    {
                        double averagePass = passTemp / count;
                        if(maxPass < averagePass)
                        {
                            maxPass = averagePass;
                            airlineTop = airlineName;
                        }
                        Console.WriteLine($"{airlineName}: {Math.Floor(averagePass)} passengers.");
                        break;
                    }
                    int passNumber = int.Parse(pass);
                    passTemp += passNumber;
                    count++;
                }
            }
            Console.WriteLine($"{airlineTop} has most passengers per flight: {Math.Floor(maxPass)}");
        }
    }
}
