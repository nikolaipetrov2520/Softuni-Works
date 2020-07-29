using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            int counter = 0;

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    counter++;

                    if (counter % 3 == 0)
                    {
                        energy += counter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
            }
            
        }
    }
}
