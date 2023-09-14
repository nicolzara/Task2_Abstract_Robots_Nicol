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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WndWorkerInfo : Window
    {
        public WndWorkerInfo()
        {
            InitializeComponent();
            this.DataContext = null;
        }
        public WndWorkerInfo(Worker w)
        {
            InitializeComponent();
            this.DataContext = null;
            this.DataContext = w;
        }
        private void btnNewWorker_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fullName = tbFullName.Text;
                string id = tbID.Text;
                DateTime bd = DateTime.Parse(tbBDate.Text);
                string email = tbEmail.Text;
            }
            catch { }
            finally {
                MessageBox.Show("thank you");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dr =MessageBox.Show("Are you shur?","Exiting without saving",MessageBoxButton.OKCancel);
            if(dr== MessageBoxResult.OK)
                this.Close();
        }
    }
}
