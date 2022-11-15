using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CountTill(4);


            //Navigator.NavigateTo(PageType.Menu);
            Console.ReadLine();
        }


        static void CountTill(int limit)
        {
            while (true)
            {
                Console.WriteLine("Something is here");
                return;
            }

        }


        public static void AddUser(User user)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5VQTP5K;Initial Catalog=Amazon;Integrated Security=True");
            SqlCommand sqlCommand =
                new SqlCommand($"INSERT INTO [dbo].[User]([Username],[Password]) VALUES ('{user.Username}','{user.Password}')", connection);

            connection.Open();

            int rowsAffected = sqlCommand.ExecuteNonQuery();
            
            connection.Close();

        }

    }
}
