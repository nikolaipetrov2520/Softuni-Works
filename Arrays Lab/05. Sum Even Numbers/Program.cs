using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] nums = new int[arr.Length];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                nums[i] = int.Parse(arr[i]);
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }

            }
            Console.WriteLine(sum);

        }
    }
}
