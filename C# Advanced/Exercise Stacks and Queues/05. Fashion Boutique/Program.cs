using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(input);

            int racks = 0;
            int sum = 0;
            int current = 0;

            while (stack.Count > 0)
            {
                while (capacity > sum && stack.Count > 0)
                {
                    current = stack.Pop();
                    sum+= current;
                }
                if (sum > capacity)
                {
                    stack.Push(current);
                }

                racks++;
                sum = 0;
            }
            if (sum > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
