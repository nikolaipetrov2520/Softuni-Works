using System;

namespace _04.Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] command = input.Split(">>>");

                if (input.Contains("Contains"))
                {
                    if (key.Contains(command[1]))
                    {
                        Console.WriteLine($"{key} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (input.Contains("Flip"))
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string start = key.Substring(0, startIndex);
                    string end = key.Substring(endIndex);

                    if (command[1] =="Upper")
                    {
                        
                        string sub = key.Substring(startIndex, endIndex - startIndex).ToUpper();
                        key = start + sub + end;
                    }
                    if (command[1] == "Lower")
                    {
                        string sub = key.Substring(startIndex, endIndex - startIndex).ToLower();
                        key = start + sub + end;
                    }

                    Console.WriteLine(key);
                }
                else if (input.Contains("Slice"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    string start = key.Substring(0, startIndex);
                    string end = key.Substring(endIndex);
                    key = start + end;
                    Console.WriteLine(key);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
