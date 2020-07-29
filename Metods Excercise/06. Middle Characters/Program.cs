using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(text[text.Length / 2 -1].ToString() + text[text.Length / 2].ToString());
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
