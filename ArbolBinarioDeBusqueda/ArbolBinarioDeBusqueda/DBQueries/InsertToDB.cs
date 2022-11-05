using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ArbolBinarioDeBusqueda.DBQueries {
    internal class InsertToDB {

        //Ejemplo tomado de:
        //https://stackoverflow.com/questions/22936361/insert-into-mysql-table-using-c-sharp

        public static void SaveKey(int key) {
            MySqlConnection connection = CreateConnection.GetConnection();
            string query = "INSERT INTO tbl_randomNumbers(randomKey) VALUES(@key);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.Add(new MySqlParameter("@key", key));

            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Dato guardado");
        }
    }
}
