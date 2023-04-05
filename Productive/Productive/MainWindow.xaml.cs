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

namespace Productive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double totalTasks = 5;
            double tasksOnTime = 3; //TODO: CHANGE IMPLEMENTAION
            EventsCompletedBlock.Text = "Events Completed this Month (" + DateTime.Now.ToString("MMMM") + "):";
            TasksCompletedBlock.Text = "Tasks Completed on Time: " + tasksOnTime;
            ProdRatioBlock.Text = "Productivity Ratio: " + ((tasksOnTime / totalTasks) * 100) + "%";
        }

        private void EventsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
