using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains("Add Stop"))
                {
                    int index = int.Parse(command[1]);
                    string insert = command[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, insert);
                    }
                    Console.WriteLine(text);

                }
                else if (input.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(text);
                }
                else if (input.Contains("Switch"))
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                    }
                    Console.WriteLine(text);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
