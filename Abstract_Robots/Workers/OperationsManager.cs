using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        private double hourlyWage;
        private int hoursOfWork;
        private double bonus;

        public OperationManager(string name, string id, DateTime bDate, string pass, double hourlyWage, int hoursOfWork, double bonus)
            : base(name, id, bDate, pass)
        {
            this.hourlyWage = hourlyWage;   
            this.hoursOfWork = hoursOfWork;
            this.bonus = bonus;
        }

        public override double salary()
        {
            return (this.hourlyWage * this.hoursOfWork) + bonus;
        }

        public void taskDone()
        {
            bonus += this.salary() * 0.03;
        }
    }
}
