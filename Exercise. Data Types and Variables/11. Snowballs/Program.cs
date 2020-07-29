using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            BigInteger highest = int.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;


            for (int i = 0; i < num; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > highest)
                {
                    highest = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }


            }

            Console.WriteLine($"{highestSnow} : {highestTime} = {highest} ({highestQuality})");
        }
    }
}
