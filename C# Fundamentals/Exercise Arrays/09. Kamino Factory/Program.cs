using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int mostSmallIndex = 0;
            int bestDNA = 0;
            int bestSum = 0;
            int[] arrBest = new int[n];
            int sempleCount = 0;

            while (input != "Clone them!")
            {
                int length = 0;
                int bestLength = 0;
                int sum = 0;
                int startIndex = 0;
                int bestStart = 0;
                int[] arr = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        length++;    
                    }
                    else
                    {
                        length = 0;
                        startIndex = i;
                    }
                    if (length > bestLength)
                    {
                        startIndex = i - 1;
                        bestLength = length;
                        bestStart = startIndex;
                       
                    }
                    sum += arr[i];
                }
                if (bestLength > bestDNA)
                {
                    bestDNA = bestLength;
                    arrBest = arr;
                    sempleCount++;
                    bestSum = sum;
                    mostSmallIndex = bestStart;
                }
                else if (bestLength == bestDNA)
                {
                    if (mostSmallIndex > bestStart)
                    {
                        arrBest = arr;
                        sempleCount++;
                        bestSum = sum;
                        mostSmallIndex = bestStart;
                    }
                    else if (mostSmallIndex == bestStart)
                    {
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            arrBest = arr;
                            sempleCount++;

                        }
                    }

                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {sempleCount} with sum: {bestSum}.");
            Console.WriteLine(String.Join(' ' ,arrBest));
        }
    }
}
