
using System;

namespace _09._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            float neededExperience = float.Parse(Console.ReadLine());
            short countOfBattles = short.Parse(Console.ReadLine());
            
            short count = 0;

            for (short i = 1; i <= countOfBattles; i++)
            {               

                if (neededExperience > 0)
                {
                    float experiencePerBattle = float.Parse(Console.ReadLine());
                    count ++;

                    if (i % 3 == 0)
                    {
                        neededExperience -= (float)(experiencePerBattle + (experiencePerBattle * 0.15));
                    }
                    else if (i % 5 == 0)
                    {
                        neededExperience -= (float)(experiencePerBattle - (experiencePerBattle * 0.1));
                    }
                    else
                    {
                        neededExperience -= experiencePerBattle;
                    }

                }
                else
                {
                    
                    break;
                }
            }
            if (neededExperience <= 0)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }
        }
    }
}
