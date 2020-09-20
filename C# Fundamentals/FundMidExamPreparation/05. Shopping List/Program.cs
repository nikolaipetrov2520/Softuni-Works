using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _05._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Urgent":
                        
                        if (!shopingList.Contains(command[1]))
                        {
                            shopingList.Insert(0, command[1]);
                        }

                        break;
                    case "Unnecessary":
                        if (shopingList.Contains(command[1]))
                        {
                            shopingList.Remove(command[1]);
                        }

                        break;
                    case "Correct":
                        if (shopingList.Contains(command[1]))
                        {
                            int index = shopingList.IndexOf(command[1]);
                            shopingList.RemoveAt(index);
                            shopingList.Insert(index, command[2]);
                        }

                        break;
                    case "Rearrange":

                        if (shopingList.Contains(command[1]))
                        {
                            shopingList.Remove(command[1]);
                            shopingList.Insert(shopingList.Count, command[1]);

                        }

                        break;

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", shopingList));

        }
    }
}
