using System;
using System.Collections.Generic;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> list= new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                list.Add((char)(input[i] + 3));
            }

            Console.WriteLine(String.Join("", list));
        }
    }
}
