using System;

namespace Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());

            double totalBill = 0.0;

            for (int i = 0; i < customers; i++)
            {
                double currentBill = 0.0;
                int count = 0;

                while (true)
                {
                    string input = Console.ReadLine();
                    if(input == "Finish")
                    {
                        if(count % 2 == 0)
                        {
                            currentBill = currentBill - (currentBill * 0.2);
                        }
                        Console.WriteLine($"You purchased {count} items for {currentBill:F2} leva.");
                        break;
                    }

                    if(input == "basket")
                    {
                        currentBill += 1.50;
                        count++;
                    }
                    else if(input == "wreath")
                    {
                        currentBill += 3.80;
                        count++;
                    }
                    else if(input == "chocolate bunny")
                    {
                        currentBill += 7.0;
                        count++;
                    }
                }
                totalBill += currentBill;
            }
            Console.WriteLine($"Average bill per client is: {(totalBill/customers):F2} leva.");
        }
    }
}
