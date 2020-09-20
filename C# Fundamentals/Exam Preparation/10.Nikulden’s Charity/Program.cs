using System;
using System.Diagnostics.CodeAnalysis;

namespace _10.Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            int sum = 0;

            while (input != "Finish")
            {
                string[] command = input.Split();

                if (input.Contains("Replace"))
                {
                    char oldChar = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);

                    text = text.Replace(oldChar, newChar);

                    Console.WriteLine(text);
                }
                if (input.Contains("Cut"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || endIndex < 0 || startIndex >= text.Length || endIndex >= text.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        string start = text.Substring(0, startIndex);
                        string end = text.Substring(endIndex + 1);

                        text = start + end;
                        Console.WriteLine(text);
                    }

                }
                if (input.Contains("Make"))
                {
                    if (command[1] == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else if (command[1] == "Lower")
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                if (input.Contains("Check"))
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                if (input.Contains("Sum"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || endIndex < 0 || startIndex >= text.Length || endIndex >= text.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        string sub = text.Substring(startIndex, endIndex - startIndex + 1);

                        for (int i = 0; i < sub.Length; i++)
                        {
                            sum += sub[i];
                            
                        }
                        Console.WriteLine(sum);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
