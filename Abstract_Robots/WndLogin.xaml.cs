﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> _workers; //אוסף עובדים 
        List<Mission> _activeMissions;//אוסף משימות פעילות
        List<RobotSpy> _activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            _workers = CreateWorkers();
            _activeRobots = CreateRobots();
            _activeMissions = CreateMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון

        public List<Worker> CreateWorkers()
        {
            List<Worker> workers = new List<Worker>();

            Worker worker = new OperationalWorker("Opp", "123456", DateTime.Parse("01.06.2011"), "123456", 32, 150);
            workers.Add(worker);
            worker = new OperationalWorker("Bob", "654321", DateTime.Parse("21.09.2016"), "654321", 34, 145);
            workers.Add(worker);
            worker = new OperationalWorker("Alice", "135790", DateTime.Parse("31.12.2023"), "135790", 35.5, 155);
            workers.Add(worker);

            worker = new OperationManager("Marcel", "121212", DateTime.Parse("12.12.2020"), "121212", 45, 150, 0);
            workers.Add(worker);
            worker = new OperationManager("David", "131313", DateTime.Parse("04.08.2012"), "131313", 50, 145, 0);
            workers.Add(worker);

            worker = new GeneralManager("Carlos", "456789", DateTime.Parse("01.02.2013"), "456789", 10550, 50);
            workers.Add(worker); 

            return workers;

        }

        public List<Worker> Workers()
        {
            List<Worker> workersToReturn = new List<Worker>();
            int counterWorkers = 0;
            int counterOperationalManager = 0;
            int counterGeneralManager = 0;
            foreach(Worker worker in this._workers)
            {
                if (workersToReturn.Count != 6)
                {
                    if(worker is OperationalWorker)
                    {
                        if (counterWorkers < 3)
                        {
                            workersToReturn.Add(worker);
                            counterWorkers++;
                        }
                    }

                    if(worker is GeneralManager)
                    {
                        if(counterGeneralManager == 0)
                        {
                            workersToReturn.Add(worker);
                            counterGeneralManager++;
                        }
                    }

                    if(worker is OperationalWorker)
                    {
                        if (counterOperationalManager < 2)
                        {
                            workersToReturn.Add(worker);
                            counterOperationalManager++;
                        }
                    }               
                }                
            }

            return workersToReturn;
        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<RobotSpy> CreateRobots()
        {
            List<RobotSpy> robots = new List<RobotSpy>();

            RobotSpy robot = new RobotFly(DateTime.Parse("01.02.2013"), 100);
            robots.Add(robot);
            robot = new RobotFly(DateTime.Now, 50);
            robots.Add(robot);
            robot = new RobotFly(DateTime.Now, 75);
            robots.Add(robot);

            robot = new RobotQuad(DateTime.Now, 100);
            robots.Add(robot);
            robot = new RobotQuad(DateTime.Now, 50);
            robots.Add(robot);
            robot = new RobotQuad(DateTime.Now, 75);
            robots.Add(robot);

            robot = new RobotWheels(DateTime.Now, 100);
            robots.Add(robot);
            robot = new RobotWheels(DateTime.Now, 50);
            robots.Add(robot);

            return robots;
        }


        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<Mission> CreateMissions()
        {
            List<Mission> missions = new List<Mission>();

            Mission mission = new Mission(DateTime.Parse("01.12.2023"), "put the box in the garage");
            missions.Add(mission);
            mission = new Mission(DateTime.Parse("04.08.2024"), "find the best computer");
            missions.Add(mission);
            mission = new Mission(DateTime.Parse("01.02.2024"), "take down the president");
            missions.Add(mission);
            mission = new Mission(DateTime.Parse("12.04.2024"), "write a song about poop");
            missions.Add(mission);
            mission = new Mission(DateTime.Parse("19.11.2023"), "take the dog out");
            missions.Add(mission);

            return missions;
        }


        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז
            string pass = tbxPassword.Password.ToString();
            string id = tbxID.Text.ToString();

            foreach (Worker worker in _workers)
            {
                if(worker.GetIdNumber().Equals(id) && worker.GetPassword().Equals(pass))
                {
                    WndMain main = new WndMain(worker, _activeMissions, _activeRobots, _workers);
                    main.ShowDialog();
                }
            }

            MessageBox.Show("Error in entering");
        }
    }
}
