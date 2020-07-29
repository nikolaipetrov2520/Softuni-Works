using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char current = input[i];
                string currentSimbol = current.ToString();
                result = result + currentSimbol;

            }
            Console.WriteLine(result);
        }
    }
}
