using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        public int Capacity = 10;

        private Dictionary<string, IRobot> data = new Dictionary<string, IRobot>();
        public IReadOnlyDictionary<string, IRobot> Robots { get { return data; } } 

        public void Manufacture(IRobot robot)
        {
            if (Robots.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            if (Robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException($"Robot {robot.Name} already exist");
            }
            data.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!Robots.ContainsKey(robotName))
            {
                throw new ArgumentException($"Robot {robotName} does not exist");
            }
            var currentRobot = Robots[robotName];
            currentRobot.Owner = ownerName;
            currentRobot.IsBought = true;
            data.Remove(robotName);
        }
    }
}
