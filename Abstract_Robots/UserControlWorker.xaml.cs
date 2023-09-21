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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UserControlWorker.xaml
    /// </summary>
    public partial class UserControlWorker : UserControl
    {
        public UserControlWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;

            lbBirthDate.Content = worker.BirthDate.ToShortDateString();
            if (worker.BirthDate.Day == DateTime.Now.Day && worker.BirthDate.Month == DateTime.Now.Month)
            {
                lbBirthDate.Content += "🎂";
            }

            string role = "";
            if(worker is OperationalWorker)
            {
                role = "operational worker";
            }
            else if(worker is OperationManager)
            {
                grid.Background = Brushes.LightBlue;
                role = "operation manager";
            }
            else if( worker is GeneralManager)
            {
                grid.Background = Brushes.CadetBlue;
                role = "general manager";
            }
            lbRole.Content = role;

            
        }
    }
}
