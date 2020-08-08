using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] city = input.Split("||");

                if (!cities.ContainsKey(city[0]))
                {
                    cities.Add(city[0], new List<int> { int.Parse(city[1]), int.Parse(city[2]) });
                }
                else
                {
                    cities[city[0]][0] += int.Parse(city[1]);
                    cities[city[0]][1] += int.Parse(city[2]);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split("=>");

                string town = command[1];

                if (input.Contains("Plunder"))
                {
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    cities[town][0] -= people;
                    cities[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[town][0] == 0 || cities[town][1] == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                if (input.Contains("Prosper"))
                {
                    int gold = int.Parse(command[2]);

                    if (gold >= 0)
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }


                input = Console.ReadLine();
            }

            var sorted = cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key);
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var pear in sorted)
            {
                Console.WriteLine($"{pear.Key} -> Population: {pear.Value[0]} citizens, Gold: {pear.Value[1]} kg");
            }
        }
    }
}
