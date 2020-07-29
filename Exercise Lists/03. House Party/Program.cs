using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> gests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length == 3)
                {
                    if (gests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        gests.Add(command[0]);
                    }
                }
                else if (command.Length == 4)
                {
                    if (gests.Contains(command[0]))
                    {
                        gests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, gests));
        }
    }
}
