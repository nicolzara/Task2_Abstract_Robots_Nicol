using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        private double hourlyWage;
        private int hoursOfWork;

        public OperationalWorker(string name, string id, DateTime bDate, string pass, double hourlyWage, int hoursOfWork)
            : base(name, id, bDate, pass) 
        {
            this.hourlyWage = hourlyWage;
            this.hoursOfWork = hoursOfWork;
        }

        public override double salary()
        {
            return (this.hourlyWage * this.hoursOfWork);
        }

    }
}
