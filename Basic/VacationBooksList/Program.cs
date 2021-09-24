using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesNumber = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysPerBook = int.Parse(Console.ReadLine());

            double hoursPerBook = pagesNumber / pagesPerHour;
            double hoursPerDay = hoursPerBook / daysPerBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
