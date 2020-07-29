using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (CheckNumForOddDigit(i) > 0)
                {
                    if (CheckSumDisisibleBy8(i))
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }

        static int CheckNumForOddDigit (int num)
        {
            string text = num.ToString();

            for (int i = 0; i < text.Length; i++)
            {
                int currentDigit = int.Parse(text[i].ToString());

                if (currentDigit % 2 != 0)
                {
                    return num;
                }
            }
            return 0;
        }

        static bool CheckSumDisisibleBy8 (int num)
        {
            string text = num.ToString();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int currentDigit = int.Parse(text[i].ToString());
                sum += currentDigit;

            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
