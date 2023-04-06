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
using System.Windows.Threading;

namespace Productive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer countdown;
        TimeSpan time = TimeSpan.FromSeconds(10);
        double totalTasks = 5;
        double tasksOnTime = 3; //TODO: CHANGE IMPLEMENTAION
        string eventName = "Event 1";
        int dumbassCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            countdown = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                NextEventBlock.Text = eventName + "\nDue:" + "\n" + DateTime.Now.ToString("M") + GetDaySuffix(DateTime.Now.ToString("d")) + " " + DateTime.Now.ToString("t") + "\n" + "Time Left:\n" + time.ToString("c");
                if (time == TimeSpan.Zero)
                {
                    countdown.Stop();
                    MessageBox.Show("YOU SUCK", "Seriously?", MessageBoxButton.OK);
                    tasksOnTime--;
                    ProgBar.Value = ((tasksOnTime / totalTasks) * 100);
                    ProdRatioBlock.Text = "\n\nProductivity Ratio: " + ((tasksOnTime / totalTasks) * 100) + "%";
                }
                time = time.Add(TimeSpan.FromSeconds(-1)); //Countdown timer implementation -> https://stackoverflow.com/questions/16748371/how-to-make-a-wpf-countdown-timer
            }, Application.Current.Dispatcher);

            countdown.Start();
            EventsCompletedBlock.Text = "Events Completed this Month (" + DateTime.Now.ToString("MMMM") + "):\n" + totalTasks.ToString();
            TasksCompletedBlock.Text = "Tasks Completed on Time: \n" + tasksOnTime;
            ProdRatioBlock.Text = "\n\nProductivity Ratio: " + ((tasksOnTime / totalTasks) * 100) + "%";
            ProgBar.Minimum= 0;
            ProgBar.Maximum = 100;
            ProgBar.Value = ((tasksOnTime / totalTasks) * 100);
        }

        public void Dumbass()
        {
            dumbassCount++;
            MessageBox.Show("You're not supposed to be here", "Go Away", MessageBoxButton.OK);
            if (dumbassCount == 5)
            {
                MessageBox.Show("Alright buddy you lost your application privileges", "GET OUT", MessageBoxButton.OK);
                System.Environment.Exit(0);
            }
        }

        public string getSuffix(string day)
        {
            switch (day)
                {
                    case "1":
                    case "21":
                    case "31":
                        return "st";
                    case "2":
                    case "22":
                        return "nd";
                    case "3":
                    case "23":
                        return "rd";
                    default:
                        return "th";
                }
            }

        private void EventsButton_Click(object sender, RoutedEventArgs e)
        {
            Dumbass();
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            Dumbass();
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            Dumbass();
        }
    }
}
