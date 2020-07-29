using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split('|').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int point = 0;

            while (input != "Game over")
            {
                string[] command = input.Split();

                if (command[0] == "Shoot")
                {
                    string[] shoot = command[1].Split('@');
                    int index = int.Parse(shoot[1]);
                    int length = int.Parse(shoot[2]);
                    int strike = -1;

                    if (shoot[0] == "Left")
                    {
                        if (index >= 0 && index < list.Count)
                        {
                            if (index - length >= 0 )
                            {
                                strike = index - length;
                            }
                            else
                            {
                                length -= index + 1;
                                while (length > list.Count)
                                {
                                    length -= list.Count;
                                }
                                strike = list.Count - (length + 1);
                            }

                        }
                        
                    }
                    else if (shoot[0] == "Right")
                    {
                        if (index >= 0 && index < list.Count)
                        {
                            if (index + length < list.Count)
                            {
                                strike = index + length;
                            }
                            else
                            {
                                length -= list.Count - (index);
                                while (length > list.Count)
                                {
                                    length -= list.Count;
                                }
                                strike = list.Count - (list.Count - length);
                            }
                        }
                    }
                    if (strike >- 0)
                    {
                        if (list[strike] >= 5)
                        {
                            list[strike] -= 5;
                            point += 5;
                        }
                        else
                        {
                            point += list[strike];
                            list[strike] = 0;
                        }
                    }
                   
                }
                else if (command[0] == "Reverse")
                {
                    list.Reverse();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" - ", list));
            Console.WriteLine($"Iskren finished the archery tournament with {point} points!");
        }
    }
}
