using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> planets = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split("<->");
                string planet = text[0];
                double rarity = double.Parse(text[1]);

                if (!planets.ContainsKey(planet))
                {
                    planets.Add(planet, new List<double> { rarity });
                }
                else
                {
                    planets[planet][0] = rarity;
                }
            }
            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                

                if (input.Contains("Rate"))
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string planet = data[0];
                    double rating = double.Parse(data[1]);
                    if (planets.ContainsKey(planet))
                    {
                        planets[planet].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (input.Contains("Update"))
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string planet = data[0];
                    double rarity = double.Parse(data[1]);

                    if (planets.ContainsKey(planet))
                    {
                        planets[planet][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (input.Contains("Reset"))
                {
                    string planet = command[1];

                    if (planets.ContainsKey(planet))
                    {
                        while (planets[planet].Count > 1)
                        {
                            planets[planet].RemoveAt(planets[planet].Count - 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                input = Console.ReadLine();
            }

            
            Dictionary<string, List<double>> averageDict = new Dictionary<string, List<double>>();

            foreach (var pear in planets)
            {
                double average = 0.0;

                for (int i = 1; i < pear.Value.Count; i++)
                {
                    average += pear.Value[i];
                }
                if (average > 0)
                {
                    average = average / (pear.Value.Count - 1);
                }
                
                averageDict.Add(pear.Key, new List<double> { pear.Value[0], average });
            }

            var sorted = averageDict.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]);
            Console.WriteLine("Plants for the exhibition:");

            foreach (var pear in sorted)
            {
                Console.WriteLine($"- {pear.Key}; Rarity: {pear.Value[0]}; Rating: {pear.Value[1]:f2}");
            }
        }
    }
}
