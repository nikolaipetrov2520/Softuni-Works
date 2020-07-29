using System;

namespace _07._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            byte numOfMonts = byte.Parse(Console.ReadLine());
            double SumOfMoney = 0;


            for (int i = 1; i <= numOfMonts; i++)
            {
                if (i > 1)
                {
                    if (i % 2 != 0)
                    {
                        SumOfMoney -= SumOfMoney * 0.16;
                    }
                }
                if (i % 4 == 0)
                {
                    SumOfMoney = SumOfMoney + SumOfMoney * 0.25 + (0.25 * neededMoney);
                }
                else
                {
                    SumOfMoney = 0.25 * neededMoney + SumOfMoney;
                }
            }

            if (SumOfMoney >= neededMoney)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {SumOfMoney - neededMoney:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {neededMoney - SumOfMoney:f2}lv. more.");
            }
        }
    }
}
