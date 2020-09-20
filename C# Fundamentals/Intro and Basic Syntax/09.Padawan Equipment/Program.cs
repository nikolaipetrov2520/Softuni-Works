using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOFBelts = double.Parse(Console.ReadLine());

            double total = priceOfLightsaber * (countOfStudents + Math.Ceiling(countOfStudents * 0.1)) + priceOfRobes * countOfStudents + priceOFBelts * (countOfStudents - (Math.Floor(countOfStudents * 1.0 / 6)));

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money:f2}lv more.");
            }
        }
    }
}
