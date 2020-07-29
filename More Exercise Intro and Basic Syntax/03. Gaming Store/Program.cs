using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Game Time")
            {
               
                switch (input)
                {
                    case "OutFall 4":
                        if (money >= 39.99)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            money -= 39.99;
                            sum += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (money >= 15.99)
                        {
                            Console.WriteLine("Bought CS: OG");
                            money -= 15.99;
                            sum += 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money >= 19.99)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            money -= 19.99;
                            sum += 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (money >= 59.99)
                        {
                            Console.WriteLine("Bought Honored 2");
                            money -= 59.99;
                            sum += 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (money >= 29.99)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            money -= 29.99;
                            sum += 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= 39.99)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            money -= 39.99;
                            sum += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                input = Console.ReadLine();
                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${money:f2}");
            }
        }
    }
}
