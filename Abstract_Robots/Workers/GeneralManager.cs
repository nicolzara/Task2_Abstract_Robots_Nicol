using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlySalary;
        private int workRobots;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, int workRobots)
            :base (name,id,bDate,pass)
        {
            this.monthlySalary = monthlySalary;
            this.workRobots = workRobots;
        }

        public override double salary()
        {
            double salary = monthlySalary;
            if(workRobots > 30)
            {
                salary += monthlySalary * 0.15;
            }

            return salary;
        }

    }
}
