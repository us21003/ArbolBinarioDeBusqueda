using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBTest {
    internal class Insert {

        public static void InsertToDB(int key) {
            MySqlConnection connection = CreateConnection.GetConnection();
            string myQuery = "INSERT INTO tbl_randomNumbers(randomKey) VALUES(@key)";

            try {
                MySqlCommand query = new MySqlCommand(myQuery, connection);
                query.Parameters.Add(new MySqlParameter("@key", key));
                query.ExecuteNonQuery();
                Console.WriteLine("Dato guardado");

            }catch(MySqlException e) {
                Console.WriteLine("Error: " + e);
            }
            connection.Close();
        }

    }
}
