using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Project91;

public class CargarDatos
{
    public static MySqlDataReader GetValues() {
        MySqlConnection connection = CreateConnection.GetConnection();
        string myQuery = "SELECT randomKey FROM tbl_randomNumbers;";

        MySqlCommand query = new MySqlCommand(myQuery, connection);
        //Se supone que esta línea es la que da el error
        MySqlDataReader dr = query.ExecuteReader();
        return dr;
    }
}