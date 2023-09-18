using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for WndMain.xaml
    /// </summary>
    public partial class WndMain : Window
    {
        private Worker worker; //עובד פעיל בטופס
        private List<Worker> activeWorkers; //אוסף עובדים 
        private List<Mission> activeMissions;//אוסף משימות פעילות
        private List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public WndMain(Worker w, List<Mission> lm, List<RobotSpy> lr, List<Worker> lw)
        {
            InitializeComponent();
            activeWorkers = lw;
            activeMissions = lm;
            activeRobots = lr;
            this.DataContext = null;
            this.DataContext = worker = w;
            LoadWorkerInfo();
        }

        private void LoadWorkerInfo()
        {
            string rule;
            if (worker is GeneralManager)
                rule = "General Manager";
            else if (worker is OperationManager)
                rule = "Operation Manager";
            else
                rule = "Operational Worker";
            tbHeader.Text = worker.ToString()+" "+rule;

            //Menu by rule
            switch (rule)
            {
                case "Operational Worker":  //hide all and load mission page
                    workPanel.Children.Add(new UcMissions(worker, activeMissions[0]));
                    mnMain.Visibility = Visibility.Hidden;
                    break;
                case "Operation Manager":   //hide robot and worker menu
                    workPanel.Background = Brushes.AliceBlue;
                    mnWorkers.Visibility = Visibility.Hidden;
                    break;
                case "General Manager":
                    mnMain.Visibility = Visibility.Visible;
                    break;
            }

        }
    }
}
