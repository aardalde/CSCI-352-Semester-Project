using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for AddEventSubWindow.xaml
    /// </summary>
    public partial class AddEventSubWindow : Window
    {
        public string EventName;
        private string Month;
        private int Day;
        private string Hour;
        private string Meridiem;

       public List<TextBox> eventList = new List<TextBox>();
       MainWindow mainWindow = new MainWindow();

        public AddEventSubWindow()
        {
            InitializeComponent();
        }

        private void setEvent()
        {
            EventsSubWindow events = new EventsSubWindow();
            TextBox eventBox = new TextBox();

            EventName = "My Event";
            Month = "May";
            Day = 4;
            Hour = "12:00";
            Meridiem = "P.M";

            eventBox.TextAlignment = TextAlignment.Center;
            eventBox.Text = "Event:" + "\n" + EventName + "\n" + Month + " " + Day + mainWindow.getSuffix(Day.ToString()) + "\n" + Hour + " " + Meridiem;
            eventBox.Width = 500;
            eventBox.Height = 175;
            eventBox.HorizontalAlignment = HorizontalAlignment.Center;
            eventBox.VerticalAlignment = VerticalAlignment.Center;
            eventBox.FontSize = 28;
            eventBox.FontWeight = FontWeights.Bold;

            eventList.Add(eventBox);

            foreach(TextBox box in eventList)
             {
                 events.EventsPanel.Children.Add(box);
             }

            

             this.Close();
             events.Show();
        }

        private void TextBar_LostFocus(object sender, RoutedEventArgs e)
        {
            FocusManager.SetFocusedElement(FocusManager.GetFocusScope(this), null);
        }

        private void TextBar_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) {
                Keyboard.ClearFocus();
            }
        }

        private void TextBar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(EventNameBar.Text.Length >= 25)
            {
                e.Handled = true;
            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Confirm_Button_Click(object sender, RoutedEventArgs e)
        {
            if(EventNameBar.Text.Length == 0)
            {
                MessageBox.Show("Please enter an event name.", "Error", MessageBoxButton.OK);
            }

            if (MonthBar.Text == "Month")
            {
                MessageBox.Show("Please choose a valid month", "Error", MessageBoxButton.OK);
            }

            if (DayBar.Text == "Day")
            {
                MessageBox.Show("Please choose a valid day", "Error", MessageBoxButton.OK);
            }

            if (HourBar.Text == "Hour")
            {
                MessageBox.Show("Please choose a valid hour.", "Error", MessageBoxButton.OK);
            }

            else
            {
                setEvent();
                Close();
            }

        }

        private void MonthBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
