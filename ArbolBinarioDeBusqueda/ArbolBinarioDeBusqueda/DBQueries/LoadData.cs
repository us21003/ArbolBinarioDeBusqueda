using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ArbolBinarioDeBusqueda.DBQueries {
    internal class LoadData {

        //Metodo para obtener las claves de la base de datos:
        public static MySqlDataReader LoadKeys() {
            MySqlConnection connection = CreateConnection.GetConnection();
            string myQuery = "SELECT randomKey FROM tbl_randomNumbers;";

            MySqlCommand query = new MySqlCommand(myQuery, connection);
            MySqlDataReader dataReader = query.ExecuteReader();

            return dataReader;
        }

    }
}
