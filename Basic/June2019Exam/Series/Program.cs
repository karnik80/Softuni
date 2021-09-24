using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch (name)
                {
                    case "Thrones":
                        budget -= price * 0.5;
                        break;
                    case "Lucifer":
                        budget -= price * 0.6;
                        break;
                    case "Protector":
                        budget -= price * 0.7;
                        break;
                    case "TotalDrama":
                        budget -= price * 0.8;
                        break;
                    case "Area":
                        budget -= price * 0.9;
                        break;
                    default:
                        budget -= price;
                        break;
                }
            }
            if(budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):F2} lv. more to buy the series!");
            }
        }
    }
}
