using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            double income = 0.0;

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Movie time!")
                {
                    Console.WriteLine($"There are {capacity} seats left in the cinema.");
                    Console.WriteLine($"Cinema income - {income} lv.");
                    break;
                }
                int seats = int.Parse(input);
                capacity -= seats;

                if (capacity < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {income} lv.");
                    break;
                }

                if(seats % 3 == 0)
                {
                    income += (seats * 5.00) - 5;
                }
                else
                {
                    income += (seats * 5.00);
                }
            }
        }
    }
}
