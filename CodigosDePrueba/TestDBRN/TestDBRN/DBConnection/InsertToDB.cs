using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TestDBRN.DBConnection {
    internal class InsertToDB {

        public static void Insert(int key) {
            SQLiteConnection connection = DBConnection.GenConnection();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO tbl_RandomNumbers(randomKey) VALUES(@key);";
            command.Parameters.Add(new SQLiteParameter("@key", key));

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
