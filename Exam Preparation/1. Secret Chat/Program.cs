using System;
using System.Linq;
using System.Text;

namespace _1._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(input);

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] operation = command.Split(":|:");

                if (command.Contains("InsertSpace"))
                {
                    sb.Insert(int.Parse(operation[1]), " ");
                    Console.WriteLine(sb);
                }
                else if (command.Contains("Reverse"))
                {
                    if (sb.ToString().Contains(operation[1]))
                    {
                        string subString = operation[1];
                        char[] charReverced = subString.ToCharArray();
                        Array.Reverse(charReverced);
                        string reverced = new string(charReverced);
                        int index = sb.ToString().IndexOf(subString);
                        sb.Remove(index, subString.Length);
                        sb.Insert(index, reverced);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command.Contains("ChangeAll"))
                {
                    sb.Replace(operation[1], operation[2]);
                    Console.WriteLine(sb);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {sb}");
        }
    }
}
