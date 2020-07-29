using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()
                .ToLower();

            CountVowels(input);

        }

        static void CountVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 97 || text[i] == 101 || text[i] == 105 || text[i] == 111 || text[i] == 117 || text[i] == 121)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}


