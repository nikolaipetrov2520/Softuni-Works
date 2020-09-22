using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];
            int[,] maxSumMatrix = new int[3,3];

            int Maxsum = int.MinValue;
            int sum = 0;

            for (int row = 0; row < dimensions[0]; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 2; row < dimensions[0]; row++)
            {
                for (int col = 2; col < dimensions[1]; col++)
                {
                    sum = matrix[row, col] + matrix[row - 1, col] + matrix[row - 1, col - 1] + matrix[row - 1, col - 2] + matrix[row - 2, col] + matrix[row - 2, col - 1] + matrix[row - 2, col - 2] + matrix[row, col - 1] + matrix[row, col - 2];

                    if (sum > Maxsum)
                    {
                        Maxsum = sum;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                maxSumMatrix[i, j] = matrix[row + i - 2, col + j - 2];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {Maxsum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{maxSumMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
