using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cow = 0; cow < input.Length; cow++)
                {
                    matrix[row, cow] = input[cow];
                }
            }
            int primariSum = 0;
            int secondariSum = 0;

            for (int i = 0; i < n; i++)
            {
                primariSum += matrix[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                secondariSum += matrix[i, n - i - 1];
            }
            int diference = Math.Abs(primariSum - secondariSum);

            Console.WriteLine(diference);
        
        }
    }
}
