using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = command[0];
            int power = command[1];

            int indexOfBomb = list.IndexOf(bomb);

            while (indexOfBomb != -1)
            {

                int startIndex = indexOfBomb - power;
                int endIndex = indexOfBomb + power;

                if (startIndex < 0)
                {

                    startIndex = 0;

                }
                if (endIndex > list.Count - 1)
                {
                    endIndex = list.Count - 1;
                }
                list.RemoveRange(startIndex, endIndex - startIndex +1);

                indexOfBomb = list.IndexOf(bomb);
            }
            Console.WriteLine(list.Sum());

        }
    }
}
