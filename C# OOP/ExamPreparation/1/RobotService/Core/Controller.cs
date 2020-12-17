using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Core
{

    public class Controller : IController
    {
        private IGarage garage = new Garage();


        public void isRobotExist(string robotName)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException($"Robot {robotName} does not exist");
            }
        }
        public string Charge(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new Charge();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} had charge procedure";
        }

        public string Chip(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new Chip();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} had chip procedure";
        }

        public string History(string procedureType)
        {
            return "";

        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            if (robotType == "HouseholdRobot")
            {
                IRobot robot = new HouseholdRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "PetRobot")
            {
                IRobot robot = new PetRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "WalkerRobot")
            {
                IRobot robot = new WalkerRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else
            {
                throw new ArgumentException($"{robotType} type doesn't exist");
            }
            return $"Robot {name} registered successfully";
        }

        public string Polish(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new Polish();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} had polish procedure";
        }

        public string Rest(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new Rest();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} had rest procedure";
        }

        public string Sell(string robotName, string ownerName)
        {
            garage.Sell(robotName, ownerName);
            var currentRobot = garage.Robots[robotName];
            if (currentRobot.IsChipped)
            {
                return $"{ownerName} bought robot with chip";
            }
            else
            {
                return $"{ownerName} bought robot without chip";
            }

        }

        public string TechCheck(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new TechCheck();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} had tech check procedure";
        }

        public string Work(string robotName, int procedureTime)
        {
            isRobotExist(robotName);
            Procedure procedure = new Work();
            var currentRobot = garage.Robots[robotName];
            procedure.DoService(currentRobot, procedureTime);
            return $"{currentRobot.Name} was working for {procedureTime} hours";
        }
    }
}
