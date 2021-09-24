using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contract = Console.ReadLine();
            string contractType = Console.ReadLine();
            string hasInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double total = 0.0;

            if(contract == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        if (hasInternet == "yes")
                        {
                            total = 5.50 + 9.98;
                        }
                        else if(hasInternet == "no")
                        {
                            total = 9.98;
                        }
                        break;
                    case "Middle":                       
                        if (hasInternet == "yes")
                        {
                            total = 18.99 + 4.35;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 18.99;
                        }
                        break;
                    case "Large":
                        if (hasInternet == "yes")
                        {
                            total = 4.35 + 25.98;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 25.98;
                        }
                        break;
                    case "ExtraLarge":
                        if (hasInternet == "yes")
                        {
                            total = 3.85 + 35.99;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 35.99;
                        }
                        break;
                }
                total *= months;
            }
            else if(contract == "two")
            {
                switch (contractType)
                {
                    case "Small":                      
                        if (hasInternet == "yes")
                        {
                            total = 5.50 + 8.58;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 8.58;
                        }
                        break;
                    case "Middle":
                        if (hasInternet == "yes")
                        {
                            total = 4.35 + 17.09;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 17.09;
                        }
                        break;
                    case "Large":
                        if (hasInternet == "yes")
                        {
                            total = 4.35 + 23.59;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 23.59;
                        }
                        break;
                    case "ExtraLarge":
                        if (hasInternet == "yes")
                        {
                            total = 3.85 + 31.79;
                        }
                        else if (hasInternet == "no")
                        {
                            total = 31.79;
                        }
                        break;
                }
                total *= months;
                total = total - (total * 0.0375);
            }

            Console.WriteLine($"{total:F2} lv.");
        }
    }
}
