using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Shoot":
                        int shootIndex = int.Parse(command[1]);
                        int power = int.Parse(command[2]);

                        if (shootIndex >= 0 && shootIndex < sequence.Count)
                        {
                            if (sequence[shootIndex] > power)
                            {
                                sequence[shootIndex] -= power;
                            }
                            else
                            {
                                sequence.RemoveAt(shootIndex);
                            }
                        }
                        break;

                    case "Add":
                        int addIndex = int.Parse(command[1]);
                        int value = int.Parse(command[2]);

                        if (addIndex >= 0 && addIndex < sequence.Count)
                        {
                            sequence.Insert(addIndex, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike":
                        int strikeIndex = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        int startIndex = strikeIndex - radius;
                        int endIndex = strikeIndex + radius;

                        if (startIndex >= 0 && endIndex < sequence.Count)
                        {
                            sequence.RemoveRange(startIndex, endIndex - startIndex + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join('|', sequence));
        }
    }
}
