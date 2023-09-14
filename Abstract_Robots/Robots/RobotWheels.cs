using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        public RobotWheels(DateTime creationDate, double batteryStatus) : base("Spyke", creationDate, batteryStatus) { } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        public override void TurnLeft()
        {
            this.TurnWheels(0, -1);
        }
        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);
        }

        private void TurnWheels(int rightDir, int leftDir)
        {
            this.UpdateBatteryStatus(4.5);
        }

        public void WaveHands()
        {
            this.UpdateBatteryStatus(2);
        }

    }
}
