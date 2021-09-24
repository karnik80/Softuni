using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dnaArr = new int[n];
            int[] bestDNA = new int[n];

            int bestCount = 0;
            int bestIndex = n;
            int bestSum = 0;
            int bestSample = 0;

            string input = string.Empty;

            int tempCount = 1;
            int sample = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Clone them!")
                {

                    break;
                }
                dnaArr = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse).ToArray();

                int localCount = 1;
                tempCount = 1;
                int localIndex = 0;
                int localSum = dnaArr.Sum();
                bool ind = true;
                for (int i = 0; i < dnaArr.Length - 1; i++)
                {
                    if (dnaArr[i] == dnaArr[i + 1])
                    {
                        if (dnaArr[i] == 1)
                        {
                            localCount++;
                            if (ind == true)
                            {
                                if (tempCount <= localCount)
                                {

                                    localIndex = i;
                                    ind = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        localCount = 1;
                        ind = true;
                    }

                    if (tempCount < localCount)
                    {
                        tempCount = localCount;
                    }
                }//for end
                sample++;

                if (bestCount < tempCount)
                {
                    bestCount = tempCount;
                    for (int i = 0; i < dnaArr.Length; i++)
                    {
                        bestDNA[i] = dnaArr[i];
                    }
                    bestIndex = localIndex;
                    bestSum = localSum;
                    bestSample = sample;
                }
                else if (bestCount == tempCount)
                {
                    if (bestIndex > localIndex)
                    {
                        bestCount = tempCount;
                        for (int i = 0; i < dnaArr.Length; i++)
                        {
                            bestDNA[i] = dnaArr[i];
                        }
                        bestIndex = localIndex;
                        bestSum = localSum;
                        bestSample = sample;
                    }
                    else if (bestIndex == localIndex)
                    {
                        if (bestSum < localSum)
                        {
                            bestCount = tempCount;
                            for (int i = 0; i < dnaArr.Length; i++)
                            {
                                bestDNA[i] = dnaArr[i];
                            }
                            bestIndex = localIndex;
                            bestSum = localSum;
                            bestSample = sample;
                        }
                    }
                }
            }//while end
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
