using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"([@#])([A-Za-z]+)(\1)([@#])([A-Za-z]+)(\3)";
            Regex regex = new Regex(patern);

            string input = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection matches = regex.Matches(input);
           

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            for (int i = 0; i < matches.Count; i++)
            {
                string first = matches[i].Groups[2].Value.ToString();
                string second = matches[i].Groups[5].Value.ToString();

                char[] charArray = first.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);

                if (reversed.Length == second.Length)
                {
                    if (reversed == second)
                    {
                        
                        result.Add($"{first} <=> {second}");
                        
                    }
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
    }
}
