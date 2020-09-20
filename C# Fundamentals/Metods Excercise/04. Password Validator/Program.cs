using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PassCheckIsValid(input);
        }

        static void PassCheckIsValid(string text)
        {
            bool isValid = true;

            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!ChekDigitsAndLetters(text))
            {
                isValid = false;
            }
            if (!CountDigits(text))
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ChekDigitsAndLetters(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!((text[i] >= 48 && text[i] <= 57) || (text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122)))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }   
            }
            return true;
        }

        static bool CountDigits(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
