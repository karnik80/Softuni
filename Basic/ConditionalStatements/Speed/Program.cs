using System;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            string message = string.Empty;

            if(speed <= 10)
            {
                message = "slow";
            }
            else if(speed > 10 && speed <= 50)
            {
                message = "average";
            }
            else if(speed > 50 && speed <= 150)
            {
                message = "fast";
            }
            else if(speed > 150 && speed <= 1000)
            {
                message = "ultra fast";
            }
            else
            {
                message = "extremely fast";
            }

            Console.WriteLine(message);
        }
    }
}
