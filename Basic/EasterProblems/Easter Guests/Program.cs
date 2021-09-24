using System;

namespace Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int bread = 0;
            int eggs = 0;
            double total = 0.0;

            if(guests % 3 == 0)
            {
                bread = guests / 3;
            }
            else
            {
                bread = guests / 3;
                bread++;
            }
            eggs = guests * 2;
            total = (bread * 4.00) + (eggs * 0.45);

            if(budget >= total)
            {
                Console.WriteLine($"Lyubo bought {bread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {(budget-total):F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {Math.Abs(budget - total):F2} lv. more.");
            }
        }
    }
}
