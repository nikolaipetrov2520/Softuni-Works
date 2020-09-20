using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heros = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();

                if (input.Contains("Enroll"))
                {
                    if (!heros.ContainsKey(command[1]))
                    {
                        heros.Add(command[1], new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} is already enrolled.");
                    }

                }
                if (input.Contains("Learn"))
                {
                    if (heros.ContainsKey(command[1]))
                    {
                        if (!heros[command[1]].Contains(command[2]))
                        {
                            heros[command[1]].Add(command[2]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} has already learnt {command[2]}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} doesn't exist.");
                    }
                }
                if (input.Contains("Unlearn"))
                {
                    if (heros.ContainsKey(command[1]))
                    {
                        if (heros[command[1]].Contains(command[2]))
                        {
                            heros[command[1]].Remove(command[2]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} doesn't know {command[2]}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} doesn't exist.");
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = heros.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            Console.WriteLine("Heroes:");

            foreach (var pear in sorted)
            {
                Console.WriteLine($"== {pear.Key}: {String.Join(", ", pear.Value)}");
            }
        }
    }
}
