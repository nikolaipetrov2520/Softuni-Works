using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{

    public abstract class Computer : Product, IComputer
    {
         private readonly List<IComponent> components;
         private readonly List<IPeripheral> peripherals;
        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => this.components;

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals;

        public override double OverallPerformance => base.OverallPerformance;

        public override decimal Price => base.Price;

        public void AddComponent(IComponent component)
        {
            if (components.Contains(component))
            {
                throw new ArgumentException($"Component {component.GetType()} already exists in {this.GetType()} with Id {this.Id}.");
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Contains(peripheral))
            {
                throw new ArgumentException($"Component {peripheral.GetType()} already exists in {this.GetType()} with Id {this.Id}.");
            }
            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            throw new NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType()}: {Manufacturer} {Model} (Id: {Id})");
            sb.AppendLine($" Components ({Components.Count}):");
            foreach (var component in Components)
            {
                sb.AppendLine($"{component}");
            }
            sb.AppendLine($" Peripherals ({Peripherals.Count}); Average Overall Performance ({Peripherals}):");
            foreach (var peripheral in Peripherals)
            {
                sb.AppendLine($"{peripheral}");
            }
            return sb.ToString().Trim();
        }
    }
}
