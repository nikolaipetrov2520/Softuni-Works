using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(data[0]))
                {
                    dict.Add(data[0], new List<string> { data[1] });
                }
                else
                {
                    if (!dict[data[0]].Contains(data[1]))
                    {
                        dict[data[0]].Add(data[1]);
                    }
                }
            }

            foreach (var pear in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(pear.Key);
                foreach (var item in pear.Value)
                {
                    Console.WriteLine("-- " + item);
                }
            }
        }
    }
}
