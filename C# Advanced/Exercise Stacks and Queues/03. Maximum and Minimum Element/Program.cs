using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command.Contains("1"))
                {
                    int[] splited = command.Split().Select(int.Parse).ToArray();

                    stack.Push(splited[1]);
                }
                else if (command.Contains("2"))
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command.Contains("3"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command.Contains("4"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    } 
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
