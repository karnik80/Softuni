using System;

namespace PiramidNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool end = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if(count >= n)
                    {
                        end = true;
                        break;
                    }
                    count++;
                    Console.Write(count.ToString() + " ");
                    
                }
                
                if(end == true)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
