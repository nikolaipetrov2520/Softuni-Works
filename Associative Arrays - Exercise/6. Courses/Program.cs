using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input =="end")
                {
                    break;
                }
                string[] command = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(command[0]))
                {
                    dict.Add(command[0], new List<string> { command[1] });
                }
                else
                {
                    dict[command[0]].Add(command[1]);
                }
            }
           
            foreach (var pear in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{pear.Key}: {pear.Value.Count}");
                List<String> sortedList = pear.Value.OrderBy(x => x).ToList();

                foreach (var item in sortedList)
                {
                    Console.WriteLine($"-- {item}");
                }
                
            }

        }
    }
}