using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBRN.DBConnection {
    internal class LoadFromDB {

        public static SQLiteDataReader Load() {

            SQLiteDataReader dr = null;
            SQLiteConnection connection = DBConnection.GenConnection();
            SQLiteCommand command = new SQLiteCommand();

            command.Connection = connection;

            command.CommandText = "SELECT * FROM tbl_RandomNumbers;";
            dr = command.ExecuteReader();
            connection.Close();

            return dr;
        }
    }
}
