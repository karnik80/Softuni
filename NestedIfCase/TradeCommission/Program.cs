using System;

namespace TradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0.0;

            if (city == "Sofia")
            {
                if(sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                }
                else if(sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                }
                else if(sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                }
                else if(sales > 10000)
                {
                    commission = sales * 0.12;
                }
                else
                {
                    commission = 0.0;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                }
                else
                {
                    commission = 0.0;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                }
                else
                {
                    commission = 0.0;
                }
            }
            else
            {
                commission = 0.0;
            }

            if(commission == 0.0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
    }
}
