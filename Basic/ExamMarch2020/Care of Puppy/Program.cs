using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            totalFood = totalFood * 1000;

            int eatenfood = 0;

            while(true)
            {
                string input = Console.ReadLine();
                if (input == "Adopted")
                {
                    break;
                }
                eatenfood += int.Parse(input);
            }
            int diff = totalFood - eatenfood;
            if(diff >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(diff)} grams more.");
            }
        }
    }
}
