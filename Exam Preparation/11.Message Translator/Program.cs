using System;
using System.Text.RegularExpressions;

namespace _11.Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]";


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, patern);

                if (match.Success)
                {
                    Console.Write(match.Groups[1].Value + ':');
                    string message = match.Groups[2].Value;

                    for (int j = 0; j < message.Length; j++)
                    {
                        Console.Write(" " + (int)message[j]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
