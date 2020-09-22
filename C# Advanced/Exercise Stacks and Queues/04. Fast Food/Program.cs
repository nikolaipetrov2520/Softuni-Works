using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);
            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int current = queue.Peek();

                if (quantity - current >= 0)
                {
                    quantity -= current;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        } 
    }
}
