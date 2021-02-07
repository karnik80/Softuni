using System;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double result = 0.0;

            if(from == "mm" && to == "m")
            {
                result = number / 1000.0;
            }
            else if(from == "mm" && to == "cm")
            {
                result = number / 10.0;
            }
            else if(from == "cm" && to == "mm")
            {
                result = number * 10;
            }
            else if (from == "cm" && to == "m")
            {
                result = number / 100.0;
            }
            else if (from == "m" && to == "mm")
            {
                result = number * 1000.0;
            }
            else if (from == "m" && to == "cm")
            {
                result = number * 100.0;
            }
            Console.WriteLine($"{result:F3}");
        }
    }
}
