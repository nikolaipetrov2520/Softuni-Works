using System;
using System.Linq;

namespace _02.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            int counter = 0;

            for (int row = 0; row < dimensions[0]; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 1; row < dimensions[0]; row++)
            {
                for (int col = 1; col < dimensions[1]; col++)
                {
                    if (matrix[row, col] == matrix[row - 1, col] && matrix[row, col] == matrix[row, col - 1] && matrix[row, col] == matrix[row - 1, col - 1])
                    {
                        counter++;
                    } 
                }
            }
            Console.WriteLine(counter);
        }
    }
}
