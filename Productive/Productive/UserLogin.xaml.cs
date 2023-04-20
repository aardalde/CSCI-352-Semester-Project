using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Productive
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (DatabaseManager.InsertUser(username, password))
            {
                MessageBox.Show("Account successfully created");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account already exists with this username, please login or try a different username");
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aaron\Source\Repos\aardalde\CSCI-352-Semester-Project\Productive\Productive\PPMDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                if (DatabaseManager.CheckUserExists(connection, username, password))
                {
                    MessageBox.Show("Login successful");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No account found, please create an account");
                }
            }
        }
    }
}