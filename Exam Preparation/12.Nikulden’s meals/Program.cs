using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _12.Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            int count = 0;

            while (input != "Stop")
            {
                string[] command = input.Split('-');

                if (input.Contains("Like"))
                {
                    string guest = command[1];
                    string meal = command[2];

                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string> { meal });
                    }
                    else
                    {
                        if (!guests[guest].Contains(meal))
                        {
                            guests[guest].Add(meal);
                        }
                    }
                }
                else if (input.Contains("Unlike"))
                {
                    string guest = command[1];
                    string meal = command[2];

                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }

                }
                input = Console.ReadLine();
            }

            var sorted = guests.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var pear in sorted)
            {
                Console.WriteLine($"{pear.Key}: {String.Join(", ", pear.Value)}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
