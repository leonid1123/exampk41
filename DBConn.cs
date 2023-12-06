using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace WindowsFormsApp1
{
    internal static class DBConn
    {
        public static MySqlConnection Connect()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;User ID=student;Password=student;Database=test");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return connection;
        }
    }
}
