using System;

namespace Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double income = (tickets * priceTicket * days);
            income = income - (income * (percent * 1.0 / 100));

            Console.WriteLine($"The profit from the movie {movie} is {income:F2} lv.");
        }
    }
}
