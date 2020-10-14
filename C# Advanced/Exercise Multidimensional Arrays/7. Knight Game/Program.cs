using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];
            int replaced = 0;
            int rowKiller = 0;
            int colKiller = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int countAttacks = 0;

                        if (board[row, col] == 'K')
                        {
                            countAttacks = GetAttacks(board, row, col, countAttacks);
                        }
                        if (countAttacks > maxAttacks)
                        {
                            maxAttacks = countAttacks;
                            rowKiller = row;
                            colKiller = col;
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    board[rowKiller, colKiller] = '0';
                    replaced++;
                }
                else
                {
                    Console.WriteLine(replaced);
                    break;
                }
            }
        }

        private static int GetAttacks(char[,] board, int row, int col, int countAttacks)
        {
            if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
        }

        private static bool IsInside(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}
