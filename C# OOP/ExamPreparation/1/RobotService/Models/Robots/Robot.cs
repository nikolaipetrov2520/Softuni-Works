using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {
        private bool isChipped;
        private string owner;
        private bool isChecked;
        private bool isBought;
        private int energy;
        private int happiness;
        public Robot(string name, int energy, int happiness, int procedureTime)
        {
            Name = name;
            Energy = energy;
            Happiness = happiness;
            ProcedureTime = procedureTime;
        }
        public string Name { get; }

        public int Happiness 
        {
            get
            {
                return happiness;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }
                this.happiness = value;
            }
        }
        public int Energy 
        { 
            get 
            {
                return energy;
            }
            set 
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }
                this.energy = value;
            }

        }
        public int ProcedureTime { get; set; }
        public string Owner 
        {
            get
            {
                return owner;
            }
            set 
            {
                owner = "Service";
            } 
        }
        public bool IsBought 
        {
            get 
            {
                return isBought;
            }
            set
            {
                isBought = false;
            }
        }
        public bool IsChipped
        {
            get
            {
                return isChipped;
            }
            set
            {
                isChipped = false;
            }
        }
        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = false;
            }
        }

        public override string ToString()
        {
            return $" Robot type: {this.GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";
        }
    }
}
