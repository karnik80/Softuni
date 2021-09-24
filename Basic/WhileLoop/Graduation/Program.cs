using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double average = 0.0;

            while(grade <= 12)
            {
                double score = double.Parse(Console.ReadLine());

                if(score >= 4)
                {
                    grade++;
                    average += score;
                }
                else
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
            }
            if(grade >= 12)
            {
                average = average / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
