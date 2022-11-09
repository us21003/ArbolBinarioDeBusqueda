using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBTest {
    internal class LoadData {

        public static MySqlDataReader LoadContent() {
            MySqlConnection connection = CreateConnection.GetConnection();
            string myQuery = "SELECT randomKey from tbl_randomNumbers";

            MySqlCommand query = new MySqlCommand(myQuery, connection);
            MySqlDataReader dr = query.ExecuteReader();
            return dr;
        }

    }
}
