using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if(month == "May" || month == "October")
            {
                priceStudio = overnights * 50.00;
                priceApartment = overnights * 65.00;
                if(overnights > 7 && overnights <= 14)
                {
                    priceStudio = priceStudio * 0.95;
                }
                else if(overnights > 14)
                {
                    priceStudio = priceStudio * 0.70;
                }
            }
            else if(month == "June" || month == "September")
            {
                priceStudio = overnights * 75.20;
                priceApartment = overnights * 68.70;

                if(overnights > 14)
                {
                    priceStudio = priceStudio * 0.80;
                }
            }
            else if(month == "July" || month == "August")
            {
                priceStudio = overnights * 76.00;
                priceApartment = overnights * 77.00;

            }
            else
            {

            }

            if(overnights > 14)
            {
                priceApartment = priceApartment * 0.90;
            }

            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
