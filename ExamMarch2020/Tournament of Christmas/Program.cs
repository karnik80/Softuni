using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int win = 0;
            int lose = 0;
            double money = 0.0;

            for (int day = 0; day < days; day++)
            {
                int winDay = 0;
                int loseDay = 0;
                double moneyDay = 0.0;

                while (true)
                {
                    string game = Console.ReadLine();
                    if (game == "Finish")
                    {
                        break;
                    }
                    string status = Console.ReadLine();

                    if(status == "win")
                    {
                        moneyDay += 20.0;
                        win++;
                        winDay++;
                    }
                    else if(status == "lose")
                    {
                        lose++;
                        loseDay++;
                    }
                }
                if(winDay > loseDay)
                {
                    moneyDay += (moneyDay * 0.1);
                }
                money += moneyDay;
            }
            if(win > lose)
            {
                money += (money * 0.2);
                Console.WriteLine($"You won the tournament! Total raised money: {money:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
        }
    }
}
