using System;

namespace _1._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                array[i] = EncriptString(input);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(SortResult(array)[i]);
            }
            

        }

        static int EncriptString (string text)
        {
            int currentResult = 0;
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 65 || text[i] == 69 || text[i] == 73 || text[i] == 79 || text[i] == 85
                    || text[i] == 97 || text[i] == 101 || text[i] == 105 || text[i] == 111 || text[i] == 117)
                {
                    currentResult = text[i] * text.Length;
                    sum += currentResult;
                }
                else
                {
                    currentResult = text[i] / text.Length;
                    sum += currentResult;
                }
            }
            return sum;

        }

        static int[] SortResult (int[] arr)
        {
            int[] result = new int[arr.Length]; 

            for (int i = 0; i < result.Length; i++)
            {
                int temp = int.MaxValue;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i > 0)
                    {
                        if (arr[j] < temp && arr[j] > result[i - 1])
                        {
                            temp = arr[j];
                        }
                    }
                    else if (temp > arr[j])
                    {
                        temp = arr[j];
                    }
                }
                result[i] = temp;
            }
            return result;
        }
    }
}
