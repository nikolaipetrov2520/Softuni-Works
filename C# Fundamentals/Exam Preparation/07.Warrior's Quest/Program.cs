using System;
using System.Text;

namespace _07.Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "For Azeroth")
            {
                string[] command = input.Split();

                if (input.Contains("GladiatorStance"))
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (input.Contains("DefensiveStance"))
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (input.Contains("Dispel"))
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index >= skill.Length)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {                      
                        skill = skill.Remove(index, 1);
                        skill = skill.Insert(index, command[2]);
                        Console.WriteLine("Success!");
                    }

                }
                else if (input.Contains("Target Change"))
                {
                    if (skill.Contains(command[2]))
                    {
                        skill = skill.Replace(command[2], command[3]);
                        Console.WriteLine(skill);
                    }
                    
                }
                else if (input.Contains("Target Remove"))
                {
                    int index = skill.IndexOf(command[2]);
                    if (index >= 0)
                    {
                        skill = skill.Remove(index, command[2].Length);
                        Console.WriteLine(skill);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }



                input = Console.ReadLine();
            }
            
        }
    }
}
