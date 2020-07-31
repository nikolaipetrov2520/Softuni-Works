using System;
using System.Collections.Generic;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int multiply = 0;
            int reserve = 0;

            if (second == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (first[0] == '0')
            {
                first = first.Substring(1);
            }

            for (int i = first.Length - 1; i >= 0; i--)
            {
                int currsentDigit = int.Parse(first[i].ToString());
                multiply = second * currsentDigit + reserve;
                reserve = 0;

                if (multiply > 9)
                {
                    reserve = multiply / 10;
                    multiply = multiply % 10;
                }
                result.Add(multiply);
            }
            if (reserve != 0)
            {
                result.Add(reserve);
            }
            result.Reverse();
            Console.WriteLine(String.Join("", result));
        }
    }
}
