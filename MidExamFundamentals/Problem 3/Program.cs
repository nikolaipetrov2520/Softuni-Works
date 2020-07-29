using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = list.Sum() * 1.0 / list.Count;

            list = list.OrderByDescending(x => x).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= average)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            while (list.Count > 5)
            {
                list.RemoveAt(5);
            }
            if (list.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(' ', list));
            }
        }
    }
}
