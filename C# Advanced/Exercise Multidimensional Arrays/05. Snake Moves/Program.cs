using System;
using System.Linq;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            char[] input = Console.ReadLine().ToCharArray();
            int index = 0;


            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (index >= input.Length)
                        {
                            index = 0;
                        }
                        matrix[row, col] = input[index];
                        index++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (index >= input.Length)
                        {
                            index = 0;
                        }
                        matrix[row, col] = input[index];
                        index++;
                    }
                }


            }
            PrintResult(rows, cols, matrix);
        }
        private static void PrintResult(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }


}

