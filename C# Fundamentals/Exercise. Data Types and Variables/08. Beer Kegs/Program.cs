using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string biggest = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * hight;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
