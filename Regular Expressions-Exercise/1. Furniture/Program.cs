using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>([A-Za-z]+)<<([\d]+\.?\d*)!(\d+)";
            List<string> items = new List<string>();
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Purchase")
            {
                Regex regex = new Regex(patern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    items.Add(match.Groups[1].Value);
                    sum += double.Parse(match.Groups[2].Value) * double.Parse(match.Groups[3].Value);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");

            if (items.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, items));
            }
            
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
