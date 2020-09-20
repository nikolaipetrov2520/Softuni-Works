using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _05.Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPatern = @"(:{2}|\*{2})([A-Z][a-z]{2,})\1";
            string digitPatern = @"\d";
            List<string> list = new List<string>();

            string input = Console.ReadLine();
            BigInteger result = 1;

            MatchCollection emojiMatches = Regex.Matches(input, emojiPatern);
            MatchCollection digitMatches = Regex.Matches(input, digitPatern);

            foreach (Match match in digitMatches)
            {               
                result *= int.Parse(match.Value);
            }
            Console.WriteLine($"Cool threshold: {result}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in emojiMatches)
            {
                string emoji = match.Groups[2].Value;
                BigInteger sum = 0;

                for (int i = 0; i < emoji.Length; i++)
                {
                    sum += emoji[i];
                }

                if (sum > result)
                {
                    list.Add(match.Value);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, list));
        }
    }
}
