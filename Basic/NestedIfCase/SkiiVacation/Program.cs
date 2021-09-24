using System;

namespace SkiiVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            double priceWithoutDisc = 0.0;
            double priceWithDisc = 0.0;
            double priceAfterRate = 0.0;

            if(roomType == "room for one person")
            {
                priceWithoutDisc = --days * 18.00;
                priceWithDisc = priceWithoutDisc;

            }
            else if(roomType == "apartment")
            {
                priceWithoutDisc = --days * 25.00;

                if (days < 10)
                {
                    priceWithDisc = priceWithoutDisc * 0.7;
                }
                else if(days >= 10 && days <= 15)
                {
                    priceWithDisc = priceWithoutDisc * 0.65;
                }
                else if(days > 15)
                {
                    priceWithDisc = priceWithoutDisc * 0.5;
                }
                else
                {

                }
            }
            else if(roomType == "president apartment")
            {
                priceWithoutDisc = --days * 35.00;

                if (days < 10)
                {
                    priceWithDisc = priceWithoutDisc * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    priceWithDisc = priceWithoutDisc * 0.85;
                }
                else if (days > 15)
                {
                    priceWithDisc = priceWithoutDisc * 0.8;
                }
                else
                {

                }
            }
            else
            {

            }

            if (rate == "positive")
            {
                priceAfterRate = priceWithDisc + (priceWithDisc * 0.25);
            }
            else if(rate == "negative")
            {
                priceAfterRate = priceWithDisc - (priceWithDisc * 0.1);
            }
            Console.WriteLine($"{priceAfterRate:F2}");
        }
    }
}
