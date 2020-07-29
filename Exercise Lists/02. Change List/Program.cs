using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        int num = int.Parse(command[1]);
                        if (list.Contains(num))
                        {
                            list.Remove(num);
                            i--;
                        }
                        
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    list.Insert(index, element);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', list));
        }
    }
}
