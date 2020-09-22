using System;
using System.Collections;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<String> songs = new Queue<string>(input);

            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string[] add = command.Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    if (songs.Contains(add[0]))
                    {
                        Console.WriteLine($"{add[0]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(add[0]);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
