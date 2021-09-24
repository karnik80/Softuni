using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());

            int foodCat = 0;
            int foodDog = 0;
            int countDay = 0;
            int biscuits = 0;
            int totalFood = 0;

            for (int day = 0; day < days; day++)
            {
                int foodPerDay = 0;
                int dogGrams = int.Parse(Console.ReadLine());
                int catGrams = int.Parse(Console.ReadLine());

                countDay++;
                if (countDay == 3)
                {
                    foodDog += dogGrams;
                    foodCat += catGrams;
                    foodPerDay = dogGrams + catGrams;
                    biscuits += (int)Math.Round((foodPerDay*1.0) * 0.1);
                    countDay = 0;
                }
                else
                {
                    foodDog += dogGrams;
                    foodCat += catGrams;
                }
                
            }

            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");

            totalFood = foodDog + foodCat;

            double percentEatenFood = ((totalFood * 1.0) / allFood) * 100;
            Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");

            double percentEatenFoodDog = ((foodDog * 1.0) / totalFood) * 100;
            Console.WriteLine($"{percentEatenFoodDog:F2}% eaten from the dog.");

            double percentEatenFoodCat = ((foodCat * 1.0) / totalFood) * 100;
            Console.WriteLine($"{percentEatenFoodCat:F2}% eaten from the cat.");
        }
    }
}
