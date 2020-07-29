using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);

                        if (index < 0 || index > list.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            list.Insert(index, num);
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);

                        if (indexToRemove < 0 || indexToRemove > list.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            list.RemoveAt(indexToRemove);
                        }
                       
                        break;
                    case "Shift":

                        int count = int.Parse(command[2]);
                        int temp = 0;
                        if (command[1] == "left")
                        {
                            
                            for (int i = 0; i < count; i++)
                            {
                                temp = list[0];
                                list.Add(temp);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                temp = list[list.Count - 1];
                                list.Insert(0, temp);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', list));
        }
    }
}
