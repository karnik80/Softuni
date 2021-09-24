using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLV = double.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0.0;
            double excellentScholarship = 0.0;

            if (incomeLV < minSalary && avgGrade > 4.5)
            {
                socialScholarship = minSalary * 0.35;
            }
            if(avgGrade >= 5.50)
            {
                excellentScholarship = avgGrade * 25;
            }

            if(socialScholarship == 0 && excellentScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > 0 && excellentScholarship == 0)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if(excellentScholarship > 0 && socialScholarship == 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if(socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if(excellentScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else
            {

            }
        }
    }
}
