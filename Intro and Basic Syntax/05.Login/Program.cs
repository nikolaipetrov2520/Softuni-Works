using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";
            char currentChar = '0';
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                currentChar = username[i];
                pass = pass + currentChar;
            }
            string password = Console.ReadLine();

            while (password != pass)
            {
                counter++;
                if(counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again. ");
                password = Console.ReadLine();
                
            }
            if (password == pass)
            {
                Console.WriteLine($"User {username} logged in. ");
            }
        }
    }
}
