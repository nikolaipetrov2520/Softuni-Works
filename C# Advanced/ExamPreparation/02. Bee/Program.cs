using System;
using System.Data;

namespace _02._Bee
{
    public class Position
    {

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
        public int Row { get; set; }

        public int Col { get; set; }

        public bool isSafe(int rowCount, int colCount, Position direction)
        {
            rowCount -= direction.Row;
            colCount -= direction.Col;

            if (Row < 0 || Col < 0)
            {
                return false;
            }
            if (Row >= rowCount || Col >= colCount)
            {
                return false;
            }
            return true;
        }

        public void CheckOtherSideMovement(int rowCount, int colCount)
        {
            if (Row < 0)
            {
                Row = rowCount - 1;
            }
            if (Col < 0)
            {
                Col = colCount - 1;
            }
            if (Row >= rowCount)
            {
                Row = 0;
            }
            if (Col >= colCount)
            {
                Col = 0;
            }

        }

        public static Position GetDirection(string command)
        {
            int row = 0;
            int col = 0;
            if (command == "left")
            {
                col = -1;
            }
            if (command == "right")
            {
                col = 1;
            }
            if (command == "up")
            {
                row = -1;
            }
            if (command == "down")
            {
                row = 1;
            }
            return new Position(row, col);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int flowers = 0;

            var bee = GetPlayerPosition(matrix);

            string command = Console.ReadLine();
            

            while (command != "End")
            {
                bee = GetPlayerPosition(matrix);
                matrix[bee.Row, bee.Col] = '.';
                Position direction = Position.GetDirection(command);
                if (bee.isSafe(n, n, direction))
                {
                    MovePlayer(bee, command);  
                }
                else
                {
                    break;
                }
                if (matrix[bee.Row, bee.Col] == 'f')
                {
                    flowers++;
                }
                if (matrix[bee.Row, bee.Col] == 'O')
                {
                    if (bee.isSafe(n, n, direction))
                    {
                        matrix[bee.Row, bee.Col] = '.';
                        MovePlayer(bee, command);
                        if (matrix[bee.Row, bee.Col] == 'f')
                        {
                            flowers++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                matrix[bee.Row, bee.Col] = 'B';
               
                command = Console.ReadLine();
            }

            if (command != "End")
            {
                Console.WriteLine("The bee got lost!");
            }
            if (flowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }

            PrinMatrix(matrix);
        }

        static Position GetPlayerPosition(char[,] matrix)
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        position = new Position(row, col);
                    }
                }
            }
            return position;
        }

        static void PrinMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static Position MovePlayer(Position bee, string command)
        {
            Position movement = Position.GetDirection(command);
            bee.Row += movement.Row;
            bee.Col += movement.Col;
            return bee;
        }
    }
}
