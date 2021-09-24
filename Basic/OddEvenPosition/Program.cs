using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0.0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            double oddSum = 0.0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            if(n == 0)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double currentNumber = double.Parse(Console.ReadLine());

                    if(n == 1)
                    {
                        Console.WriteLine($"OddSum={currentNumber:F2},");
                        Console.WriteLine($"OddMin={currentNumber:F2},");
                        Console.WriteLine($"OddMax={currentNumber:F2},");
                        Console.WriteLine($"EvenSum=0.00,");
                        Console.WriteLine("EvenMin=No,");
                        Console.WriteLine("EvenMax=No");
                    }

                    if(i % 2 == 1)
                    {
                        oddSum += currentNumber;
                        if(currentNumber > oddMax)
                        {
                            oddMax = currentNumber;
                        }

                        if(currentNumber < oddMin)
                        {
                            oddMin = currentNumber;
                        }
                    }
                    else
                    {
                        evenSum += currentNumber;
                        if(currentNumber > evenMax)
                        {
                            evenMax = currentNumber;
                        }
                        if(currentNumber < evenMin)
                        {
                            evenMin = currentNumber;
                        }
                    }
                }

                if(n > 1)
                {
                    Console.WriteLine($"OddSum={oddSum:F2},");
                    Console.WriteLine($"OddMin={oddMin:F2},");
                    Console.WriteLine($"OddMax={oddMax:F2},");
                    Console.WriteLine($"EvenSum={evenSum:F2},");
                    Console.WriteLine($"EvenMin={evenMin:F2},");
                    Console.WriteLine($"EvenMax={evenMax:F2}");
                }
            }
        }
    }
}
