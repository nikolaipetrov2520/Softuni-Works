using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";
            List<string> list = new List<string>();
            int points = 0;
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, patern);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string place = (match.Groups[2].Value);
                    points += place.Length;
                    list.Add(place);

                }

            }
            Console.WriteLine($"Destinations: {String.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}
