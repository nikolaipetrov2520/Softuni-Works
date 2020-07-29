using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int max = 0;
            int min = 0;
            int mid = 0;

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num1 > num2 || num1 > num3)
            {
                mid = num1;
            }
            else
            {
                min = num1;
            }
            if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else if (num2 > num1 || num2 > num3)
            {
                mid = num2;
            }
            else
            {
                min = num2;
            }
            if (num3 > num1 && num3 > num2)
            {
                max = num3;
            }
            else if (num3 > num1 || num3 > num2)
            {
                mid = num3;
            }
            else
            {
                min = num3;
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
