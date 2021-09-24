using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = 0.0;

            if(type == "Premiere")
            {
                income = (row * col) * 12.00;
            }
            else if(type == "Normal")
            {
                income = (row * col) * 7.50;
            }
            else if(type == "Discount")
            {
                income = (row * col) * 5.00;
            }
            else
            {

            }
            Console.WriteLine("{0:f2} leva", income);

        }
    }
}
