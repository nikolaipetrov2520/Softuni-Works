using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == ' ')
                {
                    continue;
                }
                if (charCount.ContainsKey(symbol))
                {
                    charCount[symbol]++;
                }
                else
                {
                    charCount.Add(symbol, 1);
                }
            }
            foreach (var pear in charCount)
            {
                Console.WriteLine(pear.Key + " -> " + pear.Value);
            }
        }
    }
}
