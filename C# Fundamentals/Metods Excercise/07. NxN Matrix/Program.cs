using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNxN(n);
        }

        static void PrintNxN(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintLine(num);
                Console.WriteLine();
            }
            
        }

        static void PrintLine(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
