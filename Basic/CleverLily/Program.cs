using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMach = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double money = 0;
            double totalSave = 0;

            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    money += i * 5;
                    money--;
                }
                else
                {
                    toysCount++;
                }
            }

            totalSave = (toysCount * toyPrice) + money;

            if(totalSave >= washMach)
            {
                Console.WriteLine($"Yes! {(totalSave - washMach):F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalSave - washMach):F2}");
            }
        }
    }
}
