using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");

            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var item in files)
            {
                if (!dict.ContainsKey(item.Extension))
                {
                    dict.Add(item.Extension, new Dictionary<string, double>());
                }

                dict[item.Extension].Add(item.Name, item.Length / 1024.00);
            }

            

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DirectoryTraversal.txt"))
            {
                foreach (var item in dict.OrderByDescending(i => i.Value.Count).ThenBy(i => i.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderByDescending(f => f.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }

            }



        }
    }
}
