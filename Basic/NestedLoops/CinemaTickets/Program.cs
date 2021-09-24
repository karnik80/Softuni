using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStandart = 0;
            int totalStudent = 0;
            int totalKid = 0;

            while (true)
            {
                string movie = Console.ReadLine();

                if(movie == "Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                int movieTicketSold = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();

                    if(ticketType == "End")
                    {
                        break;
                    }

                    if(ticketType == "standard")
                    {
                        totalStandart++;
                    }
                    else if(ticketType == "kid")
                    {
                        totalKid++;
                    }
                    else if(ticketType == "student")
                    {
                        totalStudent++;
                    }
                    movieTicketSold++;
                    if(movieTicketSold == capacity)
                    {
                        break;
                    }
                }
                double filledHallPerc = 0.0;
                filledHallPerc = ((movieTicketSold * 1.0) / capacity) * 100;
                Console.WriteLine($"{movie} - {filledHallPerc:F2}% full.");
            }
            int totalTicket = totalStudent + totalStandart + totalKid;
            Console.WriteLine($"Total tickets: {totalTicket}");

            double studentPer = ((totalStudent * 1.0) / totalTicket) * 100;
            Console.WriteLine($"{studentPer:F2}% student tickets.");

            double standardPer = ((totalStandart * 1.0) / totalTicket) * 100;
            Console.WriteLine($"{standardPer:F2}% standard tickets.");

            double kidPer = ((totalKid * 1.0) / totalTicket) * 100;
            Console.WriteLine($"{kidPer:F2}% kids tickets.");
        }
    }
}
