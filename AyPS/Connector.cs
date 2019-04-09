using System;
using MySql.Data.MySqlClient;
namespace AyPS
{
    public static class Connector
    {
        public static MySqlConnection Connect(String ConnectionString)
        {
            try
            {
                MySqlConnection Connection = new MySqlConnection(ConnectionString);

                Connection.Open();
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    return Connection;
                }
                return null;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                System.Windows.Forms.MessageBox.Show("Hubieron problemas durante la conexion!!!","Problemas de conexion",
                    System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
