using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<double>>();
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                string plants = Console.ReadLine();
                string[] splittedPlants = plants.Split("<->");
                string plant = splittedPlants[0];
                int rarity = int.Parse(splittedPlants[1]);
                dic.Add(plant, new List<double>());
                dic[plant].Add(rarity);

            }
            string input = Console.ReadLine();

            while (input != "Exhibition")
            {

                if (input.Contains("Rate"))
                {
                    input = input.Remove(0, 6);
                    string[] splittedInput = input.Split(" - ");
                    string plant = splittedInput[0];
                    int rating = int.Parse(splittedInput[1]);

                    if (dic.ContainsKey(plant))
                    {
                        dic[plant].Add(rating);


                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (input.Contains("Update"))
                {
                    input = input.Remove(0, 8);
                    string[] splittedInput = input.Split(" - ");
                    string plant = splittedInput[0];
                    int rating = int.Parse(splittedInput[1]);

                    if (dic.ContainsKey(plant))
                    {
                        dic[plant].RemoveAt(0);
                        dic[plant].Insert(0, rating);
                    }



                }
                if (input.Contains("Reset"))
                {
                    input = input.Remove(0, 7);
                    string[] splittedInput = input.Split(" - ");
                    string plant = splittedInput[0];
                    if (dic.ContainsKey(plant))
                    {
                        dic[plant].RemoveRange(1, dic[plant].Count - 1);
                        double num = 0;
                        dic[plant].Add(num);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in dic)
            {
                item.Value.Average();
            }


        }
    }
}
