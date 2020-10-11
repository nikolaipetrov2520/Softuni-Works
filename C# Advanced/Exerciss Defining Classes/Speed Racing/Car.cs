using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Speed_Racing
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


        public void Drive(int amauntOfKm) 
        {
            bool canMoove = FuelAmount - (FuelConsumptionPerKilometer * amauntOfKm) >= 0;

            if (canMoove) 
            {
                FuelAmount -= (FuelConsumptionPerKilometer * amauntOfKm);
                TravelledDistance += amauntOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
