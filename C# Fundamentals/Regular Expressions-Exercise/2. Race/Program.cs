using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] users = Console.ReadLine().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            Regex nameRegex = new Regex(@"[A-Za-z]");
            Regex digitRegex = new Regex(@"\d");

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection nameMaches = nameRegex.Matches(input);
                MatchCollection digitMatches = digitRegex.Matches(input);

                string name = String.Concat(nameMaches);
                int sum = digitMatches.Select(x => int.Parse(x.Value)).Sum();

                if (users.Contains(name))
                {
                    if (dict.ContainsKey(name))
                    {
                        dict[name] += sum;
                    }
                    else
                    {
                        dict.Add(name, sum);
                    }
                }

                input = Console.ReadLine();
            }
            var sorted = dict.OrderByDescending(x => x.Value).Select(x=>x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);

        }
    }
}
