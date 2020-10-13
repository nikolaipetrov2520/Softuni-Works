using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<char> list = new List<char>();
            Stack<string> commands = new Stack<string>();
            List<char> removedText = new List<char>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split();
                
                if (arr[0] == "1")
                {
                    string text = arr[1];
                    commands.Push(input);                
                    for (int j = 0; j < text.Length; j++)
                    {
                        list.Add(text[j]);
                    }
                }
                else if (arr[0] == "2")
                {
                    string text = arr[1];
                    commands.Push(input);
                    int countOfElaments = int.Parse(text);
                    int listCount = list.Count;
                    removedText.Clear();
                   

                    for (int j = listCount - 1; j >= listCount - countOfElaments; j--)
                    {
                        removedText.Add(list[j]);
                        list.RemoveAt(j);
                    }

                }
                else if (arr[0] == "3")
                {
                    string text = arr[1];              
                    int index = int.Parse(text);

                    Console.WriteLine((char)list[index - 1]);
                }
                else if (arr[0] == "4")
                {
                    string undo = commands.Pop().ToString();
                    string[] arr2 = undo.Split();
                    string undoText = arr2[1];

                    if (arr2[0] == "1")
                    {
                        int listCount = list.Count;
                        int countOfElaments = undoText.Length;

                        for (int j = listCount - 1; j >= listCount - countOfElaments; j--)
                        {
                            list.RemoveAt(j);
                        }
                    }
                    else if (arr2[0] == "2")
                    {
                        removedText.Reverse();
                        for (int j = 0; j < removedText.Count; j++)
                        {
                            list.Add(removedText[j]);
                        }
                    }
                }


            }
        }
    }
}
