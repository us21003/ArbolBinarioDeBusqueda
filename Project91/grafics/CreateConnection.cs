using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project91;

public class CreateConnection
{
    public static MySqlConnection GetConnection()
    {
        MySqlConnection cn = null;
        
        string conexionString = "SERVER = sql9.freemysqlhosting.net;PORT = 3306;DATABASE = sql9541536; UID = sql9541536;PASSWORD = SgNic8Tzul;";

        try
        {
            cn = new MySqlConnection();
            cn.ConnectionString = conexionString;
            cn.Open();
            MessageBox.Show("Conectado");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        return cn;
    }
}