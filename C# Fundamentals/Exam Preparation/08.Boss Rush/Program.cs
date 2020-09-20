using System;
using System.Text.RegularExpressions;

namespace _08.Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patern = @"\|([A-Z]{4,})\|:#([A-Za-z]+ [[A-Za-z]+)#";


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, patern);

                if (match.Success)
                {
                    string bossName = match.Groups[1].Value;
                    string title = match.Groups[2].Value;

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                  
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
                
        }
    }
}
