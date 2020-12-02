using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();

            int totalSteps = 0;
            bool target = false;

            while (steps != "Going home")
            {
                int numSteps = int.Parse(steps);
                totalSteps += numSteps;

                if(totalSteps >= 10000)
                {
                    target = true;
                    break;
                }

                steps = Console.ReadLine();
            }

            if (target)
            {
                int stepsOver = totalSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else if(totalSteps < 10000)
            {
                int addSteps = int.Parse(Console.ReadLine());
                totalSteps += addSteps;
                if(totalSteps >= 10000)
                {
                    int stepsOver = totalSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOver} steps over the goal!");
                }
                else
                {
                    int stepsToTarget = 10000 - totalSteps;
                    Console.WriteLine($"{stepsToTarget} more steps to reach goal.");
                }
            }

        }
    }
}
