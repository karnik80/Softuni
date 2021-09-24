using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int daysSpend = 0;

            while (true)
            {

                string oper = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (oper == "spend")
                {                   
                    availMoney = availMoney - money;
                    if(availMoney < 0)
                    {
                        availMoney = 0;
                    }
                    daysSpend++;

                    if(daysSpend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if(oper == "save")
                {                   
                    availMoney += money;
                    daysSpend = 0;
                }

                if(availMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
                
            }
        }
    }
}
