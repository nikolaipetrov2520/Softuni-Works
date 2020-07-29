using System;

namespace _04.National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstEmployee = byte.Parse(Console.ReadLine());
            byte secondEmployee = byte.Parse(Console.ReadLine());
            byte thirdEmployee = byte.Parse(Console.ReadLine());

            short peopleCount = short.Parse(Console.ReadLine());
            short houreCounter = 0;
            byte pauseCounter = 0;

            short SumOfEmployee = (short)(firstEmployee + secondEmployee + thirdEmployee);

            while (peopleCount > 0)
            {
                peopleCount -= SumOfEmployee;
                houreCounter++;
                pauseCounter++;

                if (pauseCounter == 3 && peopleCount > 0)
                {
                    houreCounter++;
                    pauseCounter = 0;
                }
               
            }
            Console.WriteLine($"Time needed: {houreCounter}h.");
        }

    }
}
