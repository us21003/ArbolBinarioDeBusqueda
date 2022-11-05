using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda.DBQueries {

    internal class SearchKeys {


        static bool SearchKey(int key) {
            MySqlConnection connection = CreateConnection.GetConnection();
            string myQuery = "SELECT randomKey from tbl_randomNumbers";
            string collectedKey = "";
            bool keyExist = false;

            MySqlCommand query = new MySqlCommand(myQuery, connection);
            MySqlDataReader dr = query.ExecuteReader();

            while (dr.Read()) {
                collectedKey = dr.GetString("randomKey");

                if(collectedKey == key.ToString()) {
                    keyExist = true;
                } else {
                    keyExist = false;
                }
            }
            return keyExist;
        }

        public static string PrintOutResult(int keyToSearch) {

            string result = "";

            if (SearchKey(keyToSearch)) {
                result = "La clave existe";
            } else {
                result = "La clave no existe";
            }
            return result;
        }

    }
}
