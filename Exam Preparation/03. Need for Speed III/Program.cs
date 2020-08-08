using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split('|');

                dict.Add(cars[0], new List<int> { int.Parse(cars[1]), int.Parse(cars[2]) });
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split(" : ");
                string car = command[1];

                if (input.Contains("Drive"))
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (fuel <= dict[car][1])
                    {
                        dict[car][0] += distance;
                        dict[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (dict[car][0] >= 100000)
                        {
                            dict.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (input.Contains("Refuel"))
                {
                    int fuel = int.Parse(command[2]);

                    if (fuel + dict[car][1] <= 75)
                    {
                        dict[car][1] += fuel;                       
                    }
                    else
                    {                       
                        fuel = 75 - dict[car][1];
                        dict[car][1] = 75;
                    }
                    Console.WriteLine($"{car} refueled with {fuel} liters");

                }
                else if (input.Contains("Revert"))
                {
                    int kilometers = int.Parse(command[2]);

                    if (dict[car][0] - kilometers < 10000)
                    {
                        dict[car][0] = 10000;
                    }
                    else
                    {
                        dict[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                input = Console.ReadLine();
            }

            var sorted = dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key);

            foreach (var pear in sorted)
            {
                Console.WriteLine($"{pear.Key} -> Mileage: {pear.Value[0]} kms, Fuel in the tank: {pear.Value[1]} lt.");
            }
        }
    }
}
