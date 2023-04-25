using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace Productive
{
    internal class DatabaseManager
    {
        public static bool InsertUser(string username, string password)
        {
            // Check for null inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PPMDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return false; // User already exists
                }
                else
                {
                    command = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0; // Return true if the user was successfully inserted
                }
            }
        }


        public static bool CheckUserExists(SqlConnection connection, string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue ("@Password", password);

            int result = (int)command.ExecuteScalar();
            return (result > 0);
        }
    }
}

