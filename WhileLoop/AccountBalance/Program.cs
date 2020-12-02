using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double account = 0.0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                double number = double.Parse(input);

                if(number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                account += number;
                Console.WriteLine($"Increase: {number:F2}");
            }
            Console.WriteLine($"Total: {account:F2}");
        }
    }
}
