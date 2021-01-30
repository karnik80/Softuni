using System;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setNumber = int.Parse(Console.ReadLine());

            double amount = 0.0;

            if(fruit == "Watermelon")
            {
                if(setSize == "small")
                {
                    amount = setNumber * 2 * 56.00;
                }
                else if(setSize == "big")
                {
                    amount = setNumber * 5 * 28.70;
                }
            }
            else if(fruit == "Mango")
            {
                if (setSize == "small")
                {
                    amount = setNumber * 2 * 36.66;
                }
                else if (setSize == "big")
                {
                    amount = setNumber * 5 * 19.60;
                }
            }
            else if(fruit == "Pineapple")
            {
                if (setSize == "small")
                {
                    amount = setNumber * 2 * 42.10;
                }
                else if (setSize == "big")
                {
                    amount = setNumber * 5 * 24.80;
                }
            }
            else if(fruit == "Raspberry")
            {
                if (setSize == "small")
                {
                    amount = setNumber * 2 * 20.00;
                }
                else if (setSize == "big")
                {
                    amount = setNumber * 5 * 15.20;
                }
            }

            if(amount >= 400 && amount <= 1000)
            {
                amount = amount - (amount * 0.15);
            }
            else if(amount > 1000)
            {
                amount = amount / 2;
            }
            Console.WriteLine($"{amount:F2} lv.");
        }
    }
}
