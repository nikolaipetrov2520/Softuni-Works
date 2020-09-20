using System;
using System.Collections.Generic;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] currentProduct = input.Split();

                if (!products.ContainsKey(currentProduct[0]))
                {
                    products.Add(currentProduct[0], new List<double> { double.Parse(currentProduct[1]), double.Parse(currentProduct[2]) });
                }
                else
                {
                    products[currentProduct[0]][0] = double.Parse(currentProduct[1]);
                    products[currentProduct[0]][1] += double.Parse(currentProduct[2]);
                }


                input = Console.ReadLine();
            }

            foreach (var pear in products)
            {
                Console.WriteLine($"{pear.Key} -> {pear.Value[0] * pear.Value[1]:f2}");
            }
        }
    }
}