using Robots_inc;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Abstract_Robots
{
    /// <summary>
    /// Interaction logic for UcRobot.xaml
    /// </summary>
    public partial class UcRobot : UserControl
    {
        public UcRobot(RobotSpy robot)
        {
            InitializeComponent();
        }
    }
}
