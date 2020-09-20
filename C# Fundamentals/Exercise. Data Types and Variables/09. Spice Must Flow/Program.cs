using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            uint counter = 0;
            ulong sum = 0;

            while (num >= 100)
            {
                counter++;
                sum += num;
                sum -= 26;
                num -= 10;
            }
            sum -= 26;

            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }
}
