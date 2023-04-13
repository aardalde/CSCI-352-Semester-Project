using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for NotePad.xaml
    /// </summary>
    public partial class NotePad : Window
    {
        MainWindow main = new MainWindow();
        public NotePad()
        {
            InitializeComponent();
        }

        public void AddNote()
        {
            string noteText;
            noteText = UserNoteBox.Text.ToString();

            TextBox noteTextBox = new TextBox();
            noteTextBox.Text = noteText;
            noteTextBox.Width = 200;
            noteTextBox.Height = 50;
            noteTextBox.HorizontalAlignment = HorizontalAlignment.Center;
            noteTextBox.VerticalAlignment = VerticalAlignment.Center;
            noteTextBox.FontSize = 20;

            main.NotePanel.Children.Add(noteTextBox);
            main.Show();
            this.Close();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            AddNote();
        }
    }
}
