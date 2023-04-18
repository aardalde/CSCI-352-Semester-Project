using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Productive
{
    internal class DatabaseManager
    {
        public static bool InsertUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Users (ID, Username, Password) VALUES (@id, @username, @password)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                int userId = Convert.ToInt32(command.ExecuteScalar());
                return userId > 0;
            }
        }
    }
}
