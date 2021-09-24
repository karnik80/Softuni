using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string dest = string.Empty;
            double savedMoney = 0.0;
            double budget = 0.0;
         

            while (true)
            {                
                dest = Console.ReadLine();
                if(dest == "End")
                {
                    break;
                }
                budget = double.Parse(Console.ReadLine());

                while(budget > savedMoney)
                {
                    double x = double.Parse(Console.ReadLine());
                    savedMoney += x;
                }

                savedMoney = 0.0;
                Console.WriteLine($"Going to {dest}!");
            }
        }
    }
}
