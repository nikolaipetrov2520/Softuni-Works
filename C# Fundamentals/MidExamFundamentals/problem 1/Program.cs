using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
           List<long> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = arr[0];
                long temp = 0;

                if (command == "swap")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);

                    if (index1 < index2)
                    {
                        temp = list[index1];
                        list.RemoveAt(index1);
                        list.Insert(index1, list[index2 - 1]);
                        list.RemoveAt(index2);
                        list.Insert(index2, temp);
                    }
                    else if (index1 > index2)
                    {
                        temp = list[index1];
                        list.RemoveAt(index1);
                        list.Insert(index1, list[index2]);
                        list.RemoveAt(index2);
                        list.Insert(index2, temp);
                    }
       
                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);

                    temp = list[index1] * list[index2];
                    list.RemoveAt(index1);
                    list.Insert(index1, temp);
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}
