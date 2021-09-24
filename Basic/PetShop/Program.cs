using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = int.Parse(Console.ReadLine());
            int numAnimals = int.Parse(Console.ReadLine());

            double priceDogsFood = numDogs * 2.5;
            double priceAnimals = numAnimals * 4;

            double total = priceAnimals + priceDogsFood;

            Console.WriteLine($"{total} lv.");
        }
    }
}
