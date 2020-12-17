using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;
        private List<IBakedFood> foodorder;
        private List<IDrink> drinkorder;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            foodorder = new List<IBakedFood>();
            drinkorder = new List<IDrink>();
        }

        public int TableNumber { get; }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; }

        public bool IsReserved { get; private set; }

        public decimal Price
        {
            get
            {
                return NumberOfPeople * PricePerPerson;
            }
        }

        public void Clear()
        {
            drinkorder.Clear();
            foodorder.Clear();
            IsReserved = false;
            numberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal result = 0;

            foreach (var food in foodorder)
            {
                result += food.Price;
            }
            foreach (var drink in drinkorder)
            {
                result += drink.Price;
            }
            result += Price;
            return result;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {PricePerPerson}");

            return sb.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            drinkorder.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            foodorder.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
            IsReserved = true;

        }
    }
}
