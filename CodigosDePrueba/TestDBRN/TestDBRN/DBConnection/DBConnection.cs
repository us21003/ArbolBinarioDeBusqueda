using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TestDBRN.DBConnection {
    internal class DBConnection {

        public static SQLiteConnection GenConnection() {
            SQLiteConnection connection = new SQLiteConnection("Data Source = .\\DB.sqlite3; Version = 3; New = True; Compress = True");
            try {
                connection.Open();
                Console.WriteLine("Connected");
            }catch(Exception e) {
                Console.WriteLine("Error: " + e);
            }
            return connection;
        }
    }
}
