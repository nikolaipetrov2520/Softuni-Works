using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();

                string model = inputInfo[0];
                double fuelAmount = double.Parse(inputInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(inputInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] currrent = input.Split();

                string carModel = currrent[1];
                int amountOfKm = int.Parse(currrent[2]);

                Car car = cars.FirstOrDefault(x => x.Model == carModel);

                car.Drive(amountOfKm);

                input = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
