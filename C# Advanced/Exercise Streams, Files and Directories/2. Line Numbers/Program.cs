using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Xml;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../../text.txt");

            string[] arr = new string[lines.Length];


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int count1 = CountOfLetters(line);
                int count2 = CountOfPunctoatinMarks(line);

                arr[i] = $"Line {i + 1}: {line}({count1})({count2})";

            }
            File.WriteAllLines("../../../output.txt", arr);
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];

                if (Char.IsLetter(current))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountOfPunctoatinMarks(string line)
        {
            char[] punctoationmarcs = { '-', ',', '.', '!', '?', '\'' };
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];

                if (punctoationmarcs.Contains(current))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
