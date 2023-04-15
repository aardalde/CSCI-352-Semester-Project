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
    /// Interaction logic for AddEventSubWindow.xaml
    /// </summary>
    public partial class AddEventSubWindow : Window
    {
        public AddEventSubWindow()
        {
            InitializeComponent();
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
