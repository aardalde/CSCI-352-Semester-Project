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
        int noteCount= 0;
        public NotePad()
        {
            InitializeComponent();
        }

        public void AddNote()
        {
            string noteText;
            List<TextBox> notes = new List<TextBox>();
            TextBox noteTextBox = new TextBox();

            noteText = UserNoteBox.Text;
            noteTextBox.TextAlignment = TextAlignment.Center;
            noteTextBox.Text = "Note " + noteCount + "\n" + noteText;
            noteTextBox.Width = 250;
            noteTextBox.Height = 200;
            noteTextBox.HorizontalAlignment = HorizontalAlignment.Center;
            noteTextBox.VerticalAlignment = VerticalAlignment.Center;
            noteTextBox.FontSize = 20;
            noteTextBox.TextWrapping = TextWrapping.Wrap;
            noteTextBox.AcceptsReturn = false;

            notes.Add(noteTextBox);

            foreach (TextBox b in notes) {
                main.NotePanel.Children.Add(noteTextBox);
            }

            main.Show();
            this.Hide();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            noteCount++;
            AddNote();
        }
    }
}
