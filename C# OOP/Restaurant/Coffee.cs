using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DefaultCoffeeMilliliters = 50;

        private const decimal DefaultCoffeePrice = 3.50m;

        public double Coffeine { get; set; }
        public Coffee(string name, double coffeine) : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            Coffeine = coffeine;
        }
    }
}