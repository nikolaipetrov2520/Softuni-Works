using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                switch (coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2: sum += coin; break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }

                input = Console.ReadLine();
            }
            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sum >= 2)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sum -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            sum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            sum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum >= 1)
                        {
                            Console.WriteLine($"Purchased coke");
                            sum -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
