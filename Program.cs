using System;

namespace Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxSugar = 0;
            int neededSugar = 0;

            int maxFlour = 0;
            int neededFlour = 0;

            for (int i = 0; i < n; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                neededSugar += sugar;
                neededFlour += flour;

                if(maxSugar < sugar)
                {
                    maxSugar = sugar;
                }
                if(maxFlour < flour)
                {
                    maxFlour = flour;
                }
            }
            double packetsSugar = (neededSugar*1.0) / 950;
            packetsSugar = Math.Ceiling(packetsSugar);
            Console.WriteLine($"Sugar: {packetsSugar}");

            double packetsFlour = (neededFlour * 1.0) / 750;
            packetsFlour = Math.Ceiling(packetsFlour);
            Console.WriteLine($"Flour: {packetsFlour}");

            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
