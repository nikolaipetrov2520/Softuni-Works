using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestNum(num1, num2, num3);

        }

        static void SmallestNum(int num1, int num2, int num3)
        {
            int smallestNum = int.MaxValue;

            if (num1 < smallestNum)
            {
                smallestNum = num1;
            }
            if (num2 < smallestNum)
            {
                smallestNum = num2;
            }
            if (num3 < smallestNum)
            {
                smallestNum = num3;
            }
            Console.WriteLine(smallestNum);
        }
    }
}
