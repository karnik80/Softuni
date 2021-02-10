using System;

namespace CharFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            string flow = Console.ReadLine();

            for (int i = 0; i < flow.Length; i++)
            {
                Console.WriteLine(flow[i]);
            }
        }
    }
}
