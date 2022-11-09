using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBTest {
    internal class CreateConnection {

        public static MySqlConnection GetConnection() {
            MySqlConnection conn = null;

            //Using a remote server from freemysqlhosting.net due troobleshooting with sqlite tables
            string myConnectionString = "SERVER=sql9.freemysqlhosting.net;PORT=3306;DATABASE=sql9541536; UID=sql9541536;PASSWORD=SgNic8Tzul;";

            try {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }catch(MySqlException e) {
                Console.WriteLine("Error: " + e);
            }
            return conn;
        }

    }
}
