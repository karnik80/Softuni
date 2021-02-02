using System;

namespace Cat_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sleeve = int.Parse(Console.ReadLine());
            int frontPart = int.Parse(Console.ReadLine());
            string cloth = Console.ReadLine();
            string neckTie = Console.ReadLine();

            double size = (sleeve * 2) + (frontPart * 2);
            double sizeNew = (size * 0.1) + size;
            double sizeMeters = sizeNew / 100;

            double budget = 0.0;
            if(cloth == "Linen")
            {
                budget = (sizeMeters * 15.00) + 10.00;
            }
            else if(cloth == "Cotton")
            {
                budget = (sizeMeters * 12.00) + 10.00;
            }
            else if(cloth == "Denim")
            {
                budget = (sizeMeters * 20.00) + 10.00;
            }
            else if(cloth == "Twill")
            {
                budget = (sizeMeters * 16.00) + 10.00;
            }
            else if (cloth == "Flannel")
            {
                budget = (sizeMeters * 11.00) + 10.00;
            }

            if(neckTie == "Yes")
            {
                budget += budget * 0.2;
                Console.WriteLine($"The price of the shirt is: {budget:F2}lv.");
            }
            else if(neckTie == "No")
            {
                Console.WriteLine($"The price of the shirt is: {budget:F2}lv.");
            }
        }
    }
}
