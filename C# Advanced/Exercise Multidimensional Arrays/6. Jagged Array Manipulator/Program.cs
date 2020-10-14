using System;
using System.Linq;


namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[row] = new double[data.Length];

                for (int col = 0; col < data.Length; col++)
                {
                    jagged[row][col] = data[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] currentInput = input.Split();
                string command = currentInput[0];
                int row = int.Parse(currentInput[1]);
                int col = int.Parse(currentInput[2]);
                int value = int.Parse(currentInput[3]);

                bool isValid = (row >= 0 && row < jagged.Length) && (col >= 0 && col < jagged[row].Length);

                if (command == "Add")
                {
                    if (isValid)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    if (isValid)
                    {
                        jagged[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
