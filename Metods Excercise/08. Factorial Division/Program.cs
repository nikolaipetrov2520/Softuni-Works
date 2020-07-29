using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            decimal result = Factorials(first) / Factorials(second);
            Console.WriteLine($"{result:f2}");
        }

        static Decimal Factorials(int num)
        {
            decimal factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
