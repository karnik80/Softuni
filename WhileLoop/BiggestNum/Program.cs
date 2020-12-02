using System;

namespace BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int temp = 0;

            string input = Console.ReadLine();
            
            while(input != "Stop")
            {
                temp = Convert.ToInt32(input);
                if(temp > maxNum)
                {
                    maxNum = temp;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
