using System;
using System.Reflection.Metadata.Ecma335;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isTrue = false;

            for (int i = 1; i <= n; i++)
            {
                int last = i % 10;
                int first = i / 10;
                int sum = first + last;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
                Console.WriteLine($"{i} -> {isTrue}");

            }
        }
    }
}
