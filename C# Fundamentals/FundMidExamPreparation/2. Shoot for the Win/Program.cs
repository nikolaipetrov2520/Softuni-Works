using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            List<int> indexes = new List<int>();

            while (command != "End")
            {
                int shotIndex = int.Parse(command);
                if (shotIndex >= 0 && shotIndex < sequence.Length)
                {
                    if (!indexes.Contains(shotIndex))
                    {
                        int temp = sequence[shotIndex];
                        for (int i = 0; i < sequence.Length; i++)
                        {
                            if (!indexes.Contains(i))
                            {
                                if (i == shotIndex)
                                {
                                    sequence[i] = -1;
                                }
                                else if (sequence[i] <= temp)
                                {
                                    sequence[i] += temp;
                                }
                                else if (sequence[i] > temp)
                                {
                                    sequence[i] -= temp;
                                }
                            }
                           

                        }
                        indexes.Add(shotIndex);
                    }
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"Shot targets: {indexes.Count} -> {String.Join(' ', sequence)}");
           
        }
    }
}
