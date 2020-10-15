using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            HashSet<int> equalsElement = new HashSet<int>();


            for (int i = 0; i < n + m; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    first.Add(num);
                }
                else
                {
                    second.Add(num);
                }
            }

            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    equalsElement.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", equalsElement));
        }
    }
}
