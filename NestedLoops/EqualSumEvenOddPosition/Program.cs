using System;

namespace EqualSumEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = number1; i <= number2; i++)
            {
                string ii = i.ToString();
                for (int j = 0; j < ii.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        sumEven += int.Parse(ii[j].ToString());
                    }
                    else
                    {
                        sumOdd += int.Parse(ii[j].ToString());
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
                sumEven = 0;
                sumOdd = 0;
            }
        }
    }
}
