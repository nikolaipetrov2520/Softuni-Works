using System;
using System.Collections.Generic;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, input[2]);
                        Console.WriteLine($"{username} registered {input[2]} successfully");

                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!dict.ContainsKey(username))
                    {

                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        dict.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
              
            }

            foreach (var pear in dict)
            {
                Console.WriteLine($"{pear.Key} => {pear.Value}");
            }
        }
    }
}
