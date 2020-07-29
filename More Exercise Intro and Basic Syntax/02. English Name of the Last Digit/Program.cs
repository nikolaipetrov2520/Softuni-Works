using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            char lastNum = num[num.Length - 1];
            string digit = lastNum.ToString();
            string name = "";

            if (digit == "1")
            {
                name = "one";
            }
            else if (digit == "2")
            {
                name = "two";
            }
            else if (digit == "3")
            {
                name = "three";
            }
            else if (digit == "4")
            {
                name = "four";
            }
            else if (digit == "5")
            {
                name = "five";
            }
            else if (digit == "6")
            {
                name = "six";
            }
            else if (digit == "7")
            {
                name = "seven";
            }
            else if (digit == "8")
            {
                name = "eight";
            }
            else if (digit == "9")
            {
                name = "nine";
            }
            else if (digit == "0")
            {
                name = "zero";
            }


            Console.WriteLine(name);
        }
    }   
}
