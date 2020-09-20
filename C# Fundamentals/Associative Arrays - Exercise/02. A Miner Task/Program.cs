using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> recourceQuantity = new Dictionary<string, int>();

            while (true)
            {
                string recource = Console.ReadLine();
                if (recource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (recourceQuantity.ContainsKey(recource))
                {
                    recourceQuantity[recource] += quantity;
                }
                else
                {
                    recourceQuantity.Add(recource, quantity);
                }

               
            }
            foreach (var pear in recourceQuantity)
            {
                Console.WriteLine(pear.Key + " -> " + pear.Value);
            }
        }

    }
}
