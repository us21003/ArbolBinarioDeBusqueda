using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda.DBQueries {

    internal class SearchKeys {

        //Buscar la clave en la tabla:
        //Ejemplo tomado de: https://learn.microsoft.com/en-us/answers/questions/617901/read-data-values-from-specific-row-in-sql-server-t.html
        static bool SearchKey(int key) {
            MySqlConnection connection = CreateConnection.GetConnection();
            string myQuery = "SELECT randomKey FROM tbl_randomNumbers WHERE randomKey = @key;";
            bool keyExist = false;

            MySqlCommand query = new MySqlCommand(myQuery, connection);
            query.Parameters.Add(new MySqlParameter("@key", key));
            MySqlDataReader dr = query.ExecuteReader();

            while (dr.Read()) {

                if (key == dr.GetInt32("randomKey")) {
                    keyExist = true;
                } else {
                    keyExist = false;
                }
            }
            return keyExist;
        }

        public static string PrintOutResult(int keyToSearch) {

            string result = string.Empty;

            if (SearchKey(keyToSearch)) {
                result = "La clave existe";
            } else {
                result = "La clave no existe";
            }
            return result;
        }

        public static bool CheckIfKeyExistInTable(int randomKey) {

            bool keyExist = false;

            if (SearchKey(randomKey))
                keyExist = true;
            else
                keyExist = false;

            return keyExist;
        }

    }
}
