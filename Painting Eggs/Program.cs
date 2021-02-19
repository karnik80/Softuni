using System;

namespace Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double income = 0.0;
            double end = 0.0;

            if(size == "Large")
            {
                switch (color)
                {
                    case "Red":
                        income = sets * 16.00;
                        break;
                    case "Green":
                        income = sets * 12.00;
                        break;
                    case "Yellow":
                        income = sets * 9.00;
                        break;
                }
            }
            else if(size == "Medium")
            {
                switch (color)
                {
                    case "Red":
                        income = sets * 13.00;
                        break;
                    case "Green":
                        income = sets * 9.00;
                        break;
                    case "Yellow":
                        income = sets * 7.00;
                        break;
                }
            }
            else if(size == "Small")
            {
                switch (color)
                {
                    case "Red":
                        income = sets * 9.00;
                        break;
                    case "Green":
                        income = sets * 8.00;
                        break;
                    case "Yellow":
                        income = sets * 5.00;
                        break;
                }
            }
            end = income - (income * 0.35);
            Console.WriteLine($"{end:F2} leva.");
        }
    }
}
