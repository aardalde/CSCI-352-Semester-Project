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

namespace Productive
{
    /// <summary>
    /// Interaction logic for EventsSubWindow.xaml
    /// </summary>
    public partial class EventsSubWindow : Window
    {
        AddEventSubWindow addEvent = new AddEventSubWindow();
        MainWindow main = new MainWindow();

        public EventsSubWindow()
        {
            InitializeComponent();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            addEvent.Show();
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult choice = MessageBox.Show("Are you sure you want to close Productive?", "Caution", MessageBoxButton.YesNo);

            if (choice == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}

