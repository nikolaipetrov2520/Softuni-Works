using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int sumFuel = 0;
            string currentPump = "";
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                queue.Enqueue($"{input} {i}");
            }
            for (int i = 0; i < n; i++)
            {
                currentPump = queue.Dequeue();
                queue.Enqueue(currentPump);
                int[] pump = currentPump.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int fuel = pump[0];
                int distance = pump[1];

                sumFuel += fuel;

                if (sumFuel >= distance)
                {
                    sumFuel -= distance;
                }
                else
                {
                    i = -1;
                    sumFuel = 0;
                }
            }
            currentPump = queue.Dequeue();
            int[] first = currentPump.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(first[2]);
        }
    }
}
