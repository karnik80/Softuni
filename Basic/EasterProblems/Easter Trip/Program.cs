using System;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (destination)
            {
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            price = overnights * 30.00;
                            break;
                        case "24-27":
                            price = overnights * 35.00;
                            break;
                        case "28-31":
                            price = overnights * 40.00;
                            break;
                    }
                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            price = overnights * 28.00;
                            break;
                        case "24-27":
                            price = overnights * 32.00;
                            break;
                        case "28-31":
                            price = overnights * 39.00;
                            break;
                    }
                    break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            price = overnights * 32.00;
                            break;
                        case "24-27":
                            price = overnights * 37.00;
                            break;
                        case "28-31":
                            price = overnights * 43.00;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Easter trip to {destination} : {price:F2} leva.");
        }
    }
}
