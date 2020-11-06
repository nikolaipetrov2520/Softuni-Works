using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(',').Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(',').Select(int.Parse).ToArray());

            int wreathsCount = 0;
            int stores = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentLilies = lilies.Pop();
                int currentRoses = roses.Peek();
                int sum = currentLilies + currentRoses;

                if (sum > 15)
                {
                    lilies.Push(currentLilies - 2);
                }
                else if (sum == 15)
                {
                    roses.Dequeue();
                    wreathsCount++;
                }
                else
                {
                    roses.Dequeue();
                    stores += sum;
                }
            }

            if (stores > 0)
            {
                wreathsCount += stores / 15;
            }
            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }

        }
    }
}
