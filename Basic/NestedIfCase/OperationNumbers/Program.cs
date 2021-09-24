using System;

namespace OperationNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();

            int result = 0;
            double resultDiv = 0;

           
           if (operand == "+")
                {
                    result = n1 + n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - even", operand, n1, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - odd", operand, n1, n2, result);
                    }
                }
           else if (operand == "-")
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - even", operand, n1, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - odd", operand, n1, n2, result);
                    }
                }
           else if (operand == "*")
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - even", operand, n1, n2, result);
                    }
                    else
                    {
                        Console.WriteLine("{1} {0} {2} = {3} - odd", operand, n1, n2, result);
                    }
                }
           else if (operand == "/")
           {
                if(n2 != 0)
                {
                    resultDiv = (n1*1.0) / n2;
                    Console.WriteLine("{1} / {2} = {0:f2}", resultDiv, n1, n2);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }

           }
           else if (operand == "%")
           {
                if(n2 != 0)
                {
                    result = n1 % n2;
                    Console.WriteLine("{1} % {2} = {0}", result, n1, n2);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
           }
           else
           {

           }
            

        }
    }
}
