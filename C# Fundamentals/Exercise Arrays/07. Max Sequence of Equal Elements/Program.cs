using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i -1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
