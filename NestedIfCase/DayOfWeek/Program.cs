using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string message = "";

            switch (day)
            {
                case 1:
                    message = "Monday";
                    break;
                case 2:
                    message = "Tuesday";
                    break;
                case 3:
                    message = "Wednesday";
                    break;
                case 4:
                    message = "Thursday";
                    break;
                case 5:
                    message = "Friday";
                    break;
                case 6:
                    message = "Saturday";
                    break;
                case 7:
                    message = "Sunday";
                    break;
                default:
                    message = "Error";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
