using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Subtract(sum, num3);

        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }
}
