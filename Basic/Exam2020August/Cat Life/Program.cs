using System;

namespace Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string race = Console.ReadLine();
            string gender = Console.ReadLine();

            double catMonths = 0.0;

            switch (race)
            {
                case "British Shorthair":
                    if(gender == "m")
                    {
                        catMonths = (13 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if(gender == "f")
                    {
                        catMonths = (14 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                case "Siamese":
                    if (gender == "m")
                    {
                        catMonths = (15 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if (gender == "f")
                    {
                        catMonths = (16 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                case "Persian":
                    if (gender == "m")
                    {
                        catMonths = (14 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if (gender == "f")
                    {
                        catMonths = (15 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                case "Ragdoll":
                    if (gender == "m")
                    {
                        catMonths = (16 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if (gender == "f")
                    {
                        catMonths = (17 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                case "American Shorthair":
                    if (gender == "m")
                    {
                        catMonths = (12 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if (gender == "f")
                    {
                        catMonths = (13 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                case "Siberian":
                    if (gender == "m")
                    {
                        catMonths = (11 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    else if (gender == "f")
                    {
                        catMonths = (12 * 12) / 6;
                        catMonths = Math.Floor(catMonths);
                    }
                    Console.WriteLine($"{catMonths} cat months");
                    break;
                default:
                    Console.WriteLine($"{race} is invalid cat!");
                    break;
            }
        }
    }
}
