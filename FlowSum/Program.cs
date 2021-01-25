using System;

namespace FlowSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string flow = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < flow.Length; i++)
            {
                switch (flow[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
