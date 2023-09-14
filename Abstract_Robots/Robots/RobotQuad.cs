using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        public RobotQuad(DateTime creationDate, double batteryStatus) : base("Roboquad", creationDate, batteryStatus) { } 

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }
        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, -1);
        }
        public override void TurnLeft()
        {
            this.MoveLeg(0, -1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, 1);
        }
        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, 1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, -1);
        }

        private void MoveLeg(int legId, int dir) 
        {
            this.UpdateBatteryStatus(3);
        }
    }

}
