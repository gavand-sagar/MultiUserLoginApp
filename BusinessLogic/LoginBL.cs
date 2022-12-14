using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LoginBL
    {
        List<User> users = new List<User>();
        public bool Validate(User user)
        {

            if (user == null)
            {
                return false;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5VQTP5K;Initial Catalog=Amazon;Integrated Security=True"))
                {
                    SqlCommand sqlCommand =
                    new SqlCommand($"SELECT * FROM [dbo].[User] WHERE [Username]='{user.Username}' AND [Password]='{user.Password}'", connection);

                    connection.Open();
                    var reader = sqlCommand.ExecuteReader();
                    return reader.Read();
                }               
                
            }
        }

        public bool AddUser(User user)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5VQTP5K;Initial Catalog=Amazon;Integrated Security=True");
            SqlCommand sqlCommand =
                new SqlCommand($"INSERT INTO [dbo].[User]([Username],[Password]) VALUES ('{user.Username}','{user.Password}')", connection);

            connection.Open();

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            connection.Close();
            return rowsAffected > 0;
        }

    }
}
