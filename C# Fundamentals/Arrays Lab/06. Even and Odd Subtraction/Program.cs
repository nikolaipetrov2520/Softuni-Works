using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] nums = new int[arr.Length];
            int sumEvens = 0;
            int sumOdds = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                nums[i] = int.Parse(arr[i]);
                if (nums[i] % 2 == 0)
                {
                    sumEvens += nums[i];
                }
                else
                {
                    sumOdds += nums[i];
                }

            }
            Console.WriteLine(sumEvens - sumOdds);
        }
    }
}
