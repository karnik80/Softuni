using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter architect's name : ");
            string name = Console.ReadLine();
            //Console.Write("Please enter the number of projects (from 1 to 100) : ");
            int numProjects = int.Parse(Console.ReadLine());

            int hours = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numProjects} project/s.");
        }
    }
}
