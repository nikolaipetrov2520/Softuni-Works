using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] firstRow1 = new int[arr.Length / 4];
            int[] firstRow2 = new int[arr.Length / 4];
            int[] firstRow = new int[arr.Length / 2];
            int[] secondRow = new int[arr.Length / 2];
            int[] sum = new int[arr.Length / 2];

            for (int i = 0; i < arr.Length / 4; i++)
            {
                firstRow1[i] = arr[arr.Length / 4 - i - 1];
            }        

            for (int i = 0; i < arr.Length / 4; i++)
            {
                firstRow2[i] = arr[arr.Length - i - 1];
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (i < arr.Length / 4)
                {
                    firstRow[i] = firstRow1[i];
                }
                else
                {
                    firstRow[i] = firstRow2[i - arr.Length / 4];
                }
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                secondRow[i] = arr[arr.Length / 4 + i];
            }


            for (int i = 0; i < arr.Length / 2; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }



            Console.WriteLine(String.Join(' ', sum));
        }
    }
}
