using System;

namespace SmallestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            int temp = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                temp = Convert.ToInt32(input);
                if (temp < minNum)
                {
                    minNum = temp;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
