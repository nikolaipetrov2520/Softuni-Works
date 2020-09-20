using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            List<char> result = new List<char>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    result.Add(input[i]);

                }
            }
            result.Add(input[input.Length - 1]);
            
            Console.WriteLine(String.Join("", result));
        }
    }
}
