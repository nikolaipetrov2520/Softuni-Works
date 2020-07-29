using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double singlePrice = 0;
            double totalPrice = 0;


            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 10.46;
                }
                totalPrice = numOfPeople * singlePrice;
                if (numOfPeople >= 30)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }

            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 16;
                }

                if (numOfPeople >= 100)
                {
                    numOfPeople -= 10;
                }
                totalPrice = numOfPeople * singlePrice;
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    singlePrice = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    singlePrice = 22.5;
                }
                totalPrice = numOfPeople * singlePrice;
                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    totalPrice = totalPrice - totalPrice * 0.05;
                }

            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
