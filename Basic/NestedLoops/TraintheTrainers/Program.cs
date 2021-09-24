using System;

namespace TraintheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());

            double allScore = 0.0;
            int scoreNumbers = 0;

            while (true)
            {
                string name = Console.ReadLine(); //presentation name

                if(name == "Finish")
                {
                    break;
                }

                double averagePresentation = 0.0;

                for (int i = 0; i < members; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    averagePresentation += score;
                    scoreNumbers++;
                    allScore += score;
                }
                averagePresentation = averagePresentation / members;
                Console.WriteLine($"{name} - {averagePresentation:F2}.");
            }
            allScore = allScore / scoreNumbers;
            Console.WriteLine($"Student's final assessment is {allScore:F2}.");
        }
    }
}
