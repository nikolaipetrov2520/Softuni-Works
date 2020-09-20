using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split("<->");
                string plant = text[0];
                double rarity = double.Parse(text[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new List<double> { rarity });
                }
                else
                {
                    plants[plant][0] = rarity;
                }
            }
            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                

                if (input.Contains("Rate"))
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = data[0];
                    double rating = double.Parse(data[1]);
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (input.Contains("Update"))
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string plant = data[0];
                    double rarity = double.Parse(data[1]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (input.Contains("Reset"))
                {
                    string plant = command[1];

                    if (plants.ContainsKey(plant))
                    {
                        while (plants[plant].Count > 1)
                        {
                            plants[plant].RemoveAt(plants[plant].Count - 1);
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

            foreach (var pear in plants)
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
