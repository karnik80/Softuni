using System;

namespace Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count2 = 0; int count3 = 0; int count4 = 0;
            double p1 = 0.0; double p2 = 0.0; double p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x % 2 == 0)
                {
                    count2++;
                }
                if(x % 3 == 0)
                {
                    count3++;
                }
                if(x % 4 == 0)
                {
                    count4++;
                }

            }
            p1 = ((count2 * 1.0) / n) * 100;
            p2 = ((count3 * 1.0) / n) * 100;
            p3 = ((count4 * 1.0) / n) * 100;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
