using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"%([A-Z][a-z]+)%.*?<(\w+)>.*?\|(\d*)\|.*?(\d+\.?\d*).*?\$";
            Regex regex = new Regex(patern);
            string input = Console.ReadLine();
            double totalIncome = 0;

            while (input != "end of shift")
            {
                double totalPrice = 0;
                Match match = regex.Match(input);

                if (match.Success)
                {
                    totalPrice = double.Parse(match.Groups[3].Value) * double.Parse(match.Groups[4].Value);
                    Console.WriteLine($"{match.Groups[1].Value}: {match.Groups[2].Value} - {totalPrice:f2}");
                }
                totalIncome += totalPrice;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: { totalIncome:f2}");
        }
    }
}
