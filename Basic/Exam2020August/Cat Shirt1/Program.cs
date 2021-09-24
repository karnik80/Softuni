using System;

namespace Cat_Shirt1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeve = double.Parse(Console.ReadLine());
            double frontPart = double.Parse(Console.ReadLine());
            string cloth = Console.ReadLine();
            string neckTie = Console.ReadLine();

            double size = (sleeve * 2) + (frontPart * 2);
            double sizeNew = (size * 0.1) + size;
            double sizeMeters = sizeNew / 100.0;

            double budget = 0.0;

            switch (cloth)
            {
                case "Linen":
                    budget = (sizeMeters * 15.0) + 10.0;
                    break;
                case "Cotton":
                    budget = (sizeMeters * 12.0) + 10.0;
                    break;
                case "Denim":
                    budget = (sizeMeters * 20.0) + 10.0;
                    break;
                case "Twill":
                    budget = (sizeMeters * 16.0) + 10.0;
                    break;
                case "Flannel":
                    budget = (sizeMeters * 11.0) + 10.0;
                    break;
            }

            if (neckTie == "Yes")
            {
                budget += budget * 0.2;
                Console.WriteLine($"The price of the shirt is: {budget:F2}lv.");
            }
            else if (neckTie == "No")
            {
                Console.WriteLine($"The price of the shirt is: {budget:F2}lv.");
            }
        }
    }
}
