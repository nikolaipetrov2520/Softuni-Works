using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllLines("../../../words.txt");

            var text = File.ReadAllLines("../../../text.txt");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            List<string> list = new List<string>();

            MachingWordsInText(words, text, dict);
            Result(dict, list);
            File.WriteAllLines("../../../actualResults.txt", list);

            var sorted = dict.OrderByDescending(X => X.Value);
            list.Clear();
            foreach (var item in sorted)
            {
                string result = $"{item.Key} - {item.Value}";

                list.Add(result);
            }
            File.WriteAllLines("../../../expectedResult.txt", list);

        }

        private static List<string> Result(Dictionary<string, int> dict, List<string> list)
        {
            
            foreach (var item in dict)
            {
                string result = $"{item.Key} - {item.Value}";

                list.Add(result);
            }
            return list;
        }

        private static void MachingWordsInText(string[] words, string[] text, Dictionary<string, int> dict)
        {
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    var line = text[j].Split(new char[] { ' ', ',', '.', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int c = 0; c < line.Length; c++)
                    {
                        string current = line[c].ToLower();

                        if (words[i] == current)
                        {
                            if (!dict.ContainsKey(words[i]))
                            {
                                dict.Add(words[i], 0);
                            }
                            dict[words[i]]++;
                        }
                    }
                }
            }
        }
    }
}