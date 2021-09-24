using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failNumber = int.Parse(Console.ReadLine());

            int countFail = 0;
            double average = 0;
            int problems = 0;
            string lastProblem = string.Empty;

            
            while (true)
            {
                string input = Console.ReadLine(); //task

                if (input == "Enough")
                {
                    average = average / problems;
                    Console.WriteLine($"Average score: {average:F2}");
                    Console.WriteLine($"Number of problems: {problems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                else
                {
                    lastProblem = input;
                    input = Console.ReadLine(); // score
                    int temp = int.Parse(input);
                    average += temp;
                    problems++;
                    if(temp <= 4)
                    {
                        countFail++;
                    }
                    if(countFail >= failNumber)
                    {
                        Console.WriteLine($"You need a break, {countFail} poor grades.");
                        break;
                    }
                }

            }
        }
    }
}
