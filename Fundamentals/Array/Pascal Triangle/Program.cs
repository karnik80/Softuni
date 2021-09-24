using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] main = new int[n];
            main[0] = 1;
            int count = 1;
            Console.WriteLine(main[0]);

            for (int i = 0; i < n - 1; i++)
            {
                int[] temp = new int[i + 1 + 1];

                for (int j = 0; j < temp.Length; j++)
                {
                    if (j == 0)
                    {
                        temp[j] = main[0];
                    }
                    else if (j == temp.Length - 1)
                    {
                        temp[j] = main[count - 1];
                    }
                    else
                    {
                        temp[j] = main[j - 1] + main[j];
                    }
                }
                //Copy temp to Main
                for (int k = 0; k < temp.Length; k++)
                {
                    main[k] = temp[k];
                }
                count = temp.Length;
                Console.WriteLine(string.Join(" ", temp));
            }
        }
    }
}
