using System;
using System.Linq;

namespace _06._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int position = 0;
            int counter = 0;

            while (input != "Love!")
            {
                string[] command = input.Split();
                int jump = int.Parse(command[1]);
                position += jump;
                if (position >= neighborhood.Length)
                {
                    position = 0;
                }
                if (neighborhood[position] >= 2)
                {
                    neighborhood[position] -= 2;
                    
                    if (neighborhood[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }


                input = Console.ReadLine();
            }
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] != 0)
                {
                    counter++;
                }

            }

            Console.WriteLine($"Cupid's last position was {position}.");
            if (counter == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
