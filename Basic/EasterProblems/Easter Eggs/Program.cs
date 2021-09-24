using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            for (int i = 0; i < eggs; i++)
            {
                string input = Console.ReadLine();

                if(input == "red")
                {
                    red++;
                }
                else if(input == "orange")
                {
                    orange++;
                }
                else if(input == "blue")
                {
                    blue++;
                }
                else if(input == "green")
                {
                    green++;
                }
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            string color = string.Empty;
            int max = 0;
            if(max <= red)
            {
                color = "red";
                max = red;
            }
            if(max <= orange)
            {
                color = "orange";
                max = orange;
            }
            if(max <= blue)
            {
                color = "blue";
                max = blue;
            }
            if(max <= green)
            {
                color = "green";
                max = green;
            }

            Console.WriteLine($"Max eggs: {max} -> {color}");
        }
    }
}
