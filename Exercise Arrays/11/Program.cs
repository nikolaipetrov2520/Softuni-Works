using System;
using System.Linq;
 
namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte DnaLength = sbyte.Parse(Console.ReadLine());
            sbyte mostOnesCount = 0;
            sbyte bestStartingIndex = sbyte.MaxValue;
            sbyte bestSum = 0;
            sbyte[] bestSequence = new sbyte[DnaLength];
            sbyte sampleCount = 0;
            sbyte bestSample = 0;
            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                sbyte onesCount = 1;
                sbyte startingIndex = 0;
                sbyte sequenceSum = 0;

               
                sbyte[] sequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(sbyte.Parse).ToArray();
                sampleCount++;

                for (sbyte i = 0; i < sequence.Length - 1; i++)
                {
                    

                    if (sequence[i] == 1 && sequence[i + 1] == 1)
                    {
                        startingIndex = i;
                        onesCount++;
                    }
                }

                for (sbyte i = 0; i < sequence.Length; i++)
                {
                    sequenceSum += sequence[i];
                }

                if (onesCount > mostOnesCount)
                {
                    mostOnesCount = onesCount;
                    bestStartingIndex = startingIndex;
                    bestSum = sequenceSum;
                    bestSample = sampleCount;

                    for (sbyte i = 0; i < bestSequence.Length; i++)
                    {
                        bestSequence[i] = sequence[i];
                    }
                }

                else if (onesCount == mostOnesCount && startingIndex < bestStartingIndex)
                {
                    mostOnesCount = onesCount;
                    bestStartingIndex = startingIndex;
                    bestSum = sequenceSum;
                    bestSample = sampleCount;

                    for (sbyte i = 0; i < bestSequence.Length; i++)
                    {
                        bestSequence[i] = sequence[i];
                    }
                }

                else if (onesCount == mostOnesCount && startingIndex == bestStartingIndex && sequenceSum > bestSum)
                {
                    mostOnesCount = onesCount;
                    bestStartingIndex = startingIndex;
                    bestSum = sequenceSum;
                    bestSample = sampleCount;

                    for (sbyte i = 0; i < bestSequence.Length; i++)
                    {
                        bestSequence[i] = sequence[i];
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}