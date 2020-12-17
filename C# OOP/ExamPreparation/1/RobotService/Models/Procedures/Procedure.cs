using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected readonly List<IRobot> robots;
        public Procedure()
        {
            robots = new List<IRobot>();
        }
        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if (robot.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Robot doesn't have enough procedure time");
            }
            procedureTime -= robot.ProcedureTime;
        }
        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            foreach (var robot in robots)
            {
                sb.AppendLine(robot.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
