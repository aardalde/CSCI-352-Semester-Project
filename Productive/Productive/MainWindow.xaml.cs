﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private DispatcherTimer countdown;
        private TimeSpan time = TimeSpan.FromSeconds(647532);
        private double totalTasks = 4;
        private double tasksOnTime = 3; //TODO: CHANGE IMPLEMENTAION
        private string eventName;
        private string day;
        private string month;
        private string hour;
        private string meridian;

        public MainWindow()
        {
            InitializeComponent();
            EventsCompletedBlock.Text = "Events Completed this Month (" + DateTime.Now.ToString("MMMM") + "):\n" + totalTasks.ToString();
            TasksCompletedBlock.Text = "Tasks Completed on Time: \n" + tasksOnTime;
            ProdRatioBlock.Text = "\n\nProductivity Ratio: " + ((tasksOnTime / totalTasks) * 100) + "%";
            ProgBar.Value = ((tasksOnTime / totalTasks) * 100);
        }

        public void updateEvent() {
            eventName = "My Event";
            month = "May ";
            day = "4";
            hour = "12:00";
            meridian = "PM";

            countdown = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                NextEventBlock.Text = eventName + "\nDue:" + "\n" + month + day + getSuffix(day) + " " + hour + " " + meridian + "\n\n" + "Time Left:\n" + time.ToString("c");
                if (time == TimeSpan.Zero)
                {
                    countdown.Stop();
                    UpdateProductivity();
                }
                time = time.Add(TimeSpan.FromSeconds(-1)); //Countdown timer implementation -> https://stackoverflow.com/questions/16748371/how-to-make-a-wpf-countdown-timer
            }, Application.Current.Dispatcher);

            countdown.Start();
        }

        public void UpdateProductivity()
        {
            ProdRatioBlock.Text = "\n\nProductivity Ratio: " + ((tasksOnTime / totalTasks) * 100) + "%";
            ProgBar.Value = ((tasksOnTime / totalTasks) * 100);
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
            EventsSubWindow events = new EventsSubWindow();
            events.Show();
            this.Close();
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Note_Button_Click(object sender, RoutedEventArgs e)
        { 
            NotePad notePad = new NotePad();
            Hide();
            notePad.Show();
        }

        private void ProgBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgBar.Minimum = 0;
            ProgBar.Maximum = 100;

            UpdateProductivity();
        }

        private void User_Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                // Returns to user's current application state
            }
        }
    }
}
