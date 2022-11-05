using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ArbolBinarioDeBusqueda.DBQueries {
    internal class CreateConnection {

        //Ejemplo de conexion a base de datos tomado de:
        //https://dev.mysql.com/doc/connector-net/en/connector-net-connections-string.html
        //https://stackoverflow.com/questions/15094819/how-to-connect-to-a-remote-mysql-server-using-c

        public static MySqlConnection GetConnection() {
            MySqlConnection conn = null;
            string myConnectionString = "SERVER=sql9.freemysqlhosting.net;PORT=3306;DATABASE=sql9541536; UID=sql9541536;PASSWORD=SgNic8Tzul;";

            try {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Console.WriteLine("Connected");
            }catch(MySqlException e) {
                Console.WriteLine("Error: " + e);
            }
            return conn;
        }

    }
}
