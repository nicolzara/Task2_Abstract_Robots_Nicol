using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class Mission
    {
        private DateTime dueDate;   // Mission Date and time
        private string desc;        // Mission description
        private bool isFinished;    // Finish - yes/no

        public Mission(DateTime dueDate, string desc)
        {
            this.dueDate = dueDate;
            this.desc = desc;
            isFinished = false;
        }

        public void SetIsFinished()
        {
            this.isFinished = !isFinished;
        }

        public DateTime DueDate 
        { 
            get { return dueDate; }
            set { dueDate=value; }
        }
        public string Description 
        { 
            get { return desc; }
            set { desc = value; }
        }
    }
}
