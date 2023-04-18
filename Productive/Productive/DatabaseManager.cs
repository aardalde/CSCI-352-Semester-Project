using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Productive
{
    internal class DatabaseManager //This class will be responsible for all interactions with the relational database (e.g., storing the users username and password)
    {
        public static bool InsertUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
