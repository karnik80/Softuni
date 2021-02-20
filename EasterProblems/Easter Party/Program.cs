using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double priceCake = budget * 0.1;
            double priceWithoutDiscount = guests * pricePerPerson;
            double priceWithDiscount = 0.0;
            double total = 0.0;

            if(guests >= 10 && guests <= 15)
            {
                priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * 0.15);
            }
            else if(guests > 15 && guests <= 20)
            {
                priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * 0.20);
            }
            else if(guests > 20)
            {
                priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * 0.25);
            }
            else
            {
                priceWithDiscount = priceWithoutDiscount;
            }
            total = priceWithDiscount + priceCake;

            if(budget >= total)
            {
                Console.WriteLine($"It is party time! {(budget-total):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(budget - total):F2} leva needed.");
            }
        }
    }
}
