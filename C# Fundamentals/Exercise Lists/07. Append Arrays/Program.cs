using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> list = input.Split('|').ToList();
            List<string> secondList = new List<string>();

            while (list.Count > 0)
            {
                string[] arr = list[list.Count - 1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                list.RemoveAt(list.Count - 1);

                for (int i = 0; i < arr.Length; i++)
                {
                    secondList.Add(arr[i]);
                } 
            }
            Console.WriteLine(String.Join(' ', secondList));
        }
    }
}
