using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mater = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isLegendary = false;
            string legendaryItem = "";
            mater.Add("shards", 0);
            mater.Add("fragments", 0);
            mater.Add("motes", 0);

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        string material = input[i].ToLower();
                        
                        if (material == "shards")
                        {
                            mater["shards"] += int.Parse(input[i - 1]);
                        }
                        else if (material == "fragments")
                        {
                            mater["fragments"] += int.Parse(input[i - 1]);
                        }
                        else if (material == "motes")
                        {
                            mater["motes"] += int.Parse(input[i - 1]);
                        }
                        else
                        {
                            junk.Add(material, int.Parse(input[i - 1]));
                        }

                        if (material == "shards")
                        {
                            if (mater["shards"] >= 250)
                            {
                                isLegendary = true;
                                legendaryItem = "Shadowmourne";
                                mater["shards"] -= 250;
                                break;                              
                            }
                        }
                        else if (material == "fragments")
                        {
                            if (mater["fragments"] >= 250)
                            {
                                isLegendary = true;
                                legendaryItem = "Valanyr";
                                mater["fragments"] -= 250;
                                break;
                            }
                        }
                        else if (material == "motes")
                        {
                            if (mater["motes"] >= 250)
                            {
                                isLegendary = true;
                                legendaryItem = "Dragonwrath";
                                mater["motes"] -= 250;
                                break;
                            }
                        }
                    }

                }
                if (isLegendary)
                {
                    break;
                }
            }

            Console.WriteLine($"{legendaryItem} obtained! ");
             
            foreach (var pear in mater.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pear.Key}: {pear.Value}");
            }
            foreach (var pear in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pear.Key}: {pear.Value}");
            }
        }
    }
}
