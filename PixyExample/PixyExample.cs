using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using Pixy;
using WPILib.SmartDashboard;

namespace PixyExample
{
    public class PixyExample : IterativeRobot
    {
        PixyCamera Pixy;
        public override void RobotInit()
        {
            Pixy = new PixyCamera();
            Pixy.Initialize();
            SmartDashboard.PutBoolean("Pixy Status", Pixy.IsConnected);
        }

        public override void AutonomousInit()
        {
            SmartDashboard.PutBoolean("Pixy Status", Pixy.IsConnected);
            BlockArray blocks = new BlockArray(2);
            SmartDashboard.PutNumber("Pixy Count", Pixy.GetBlocks(2, blocks));

        }

        public override void AutonomousPeriodic()
        {
            BlockArray blocks = new BlockArray(2);
            SmartDashboard.PutNumber("Pixy Count", Pixy.GetBlocks(2, blocks));
            SmartDashboard.PutNumber("Pixy Area", blocks.getitem(0).height * blocks.getitem(0).width);
        }

        public override void TeleopPeriodic()
        {
            SmartDashboard.PutBoolean("Pixy Status", Pixy.IsConnected);
        }

        public override void TestPeriodic()
        {

        }
    }
}
