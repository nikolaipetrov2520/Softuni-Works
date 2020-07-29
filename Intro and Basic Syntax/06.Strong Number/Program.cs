using System;
using System.Threading;

namespace _06.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char currentNum = '0';
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                currentNum = input[i];
                string num = currentNum.ToString();
                int digit = int.Parse(num);
                int factorial = 1;

                for (int c = 1; c <= digit; c++)
                {
                    factorial = factorial * c;
                }
                result += factorial;
            }
            int inputNum = int.Parse(input);
            if (inputNum == result)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
