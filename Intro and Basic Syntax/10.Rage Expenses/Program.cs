using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double price = 0;
            int keyboardCount = 0;


            price += (lostGames / 2) * headsetPrice;


            price += (lostGames / 3) * mousePrice;

            price += (lostGames / 6) * keyboardPrice;

            price += (lostGames / 12) * displayPrice;


            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
