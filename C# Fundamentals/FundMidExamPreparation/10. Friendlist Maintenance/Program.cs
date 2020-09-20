using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            int blacklistCount = 0;
            int lostCount = 0;

            while (input != "Report")
            {
                string[] command = input.Split();

                if (command[0] == "Blacklist")
                {
                    if (friends.Contains(command[1]))
                    {
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        blacklistCount++;
                        int index = friends.IndexOf(command[1]);
                        friends.RemoveAt(index);
                        friends.Insert(index, "Blacklisted");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                    {
                        Console.WriteLine($"{friends[index]} was lost due to an error.");
                        lostCount++;
                        friends.RemoveAt(index);
                        friends.Insert(index, "Lost");
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < friends.Count)         
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {command[2]}.");
                        friends.RemoveAt(index);
                        friends.Insert(index, command[2]);      
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {blacklistCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(String.Join(' ', friends));
        }
    }
}
