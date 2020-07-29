using System;
using System.Linq;

namespace _06._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int c = i + 1; c < arr.Length; c++)
                {
                    rightSum += arr[c];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                
            }
            Console.WriteLine("no");
        }
    }
}
