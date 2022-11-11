﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArbolBinarioDeBusqueda.Logic;
using MySql.Data.MySqlClient;

namespace ArbolBinarioDeBusqueda.DBQueries {
    internal class LoadData {

        //Metodo para obtener las claves de la base de datos:
        //Ejemplo tomado de: https://dev.mysql.com/doc/dev/connector-net/6.10/html/T_MySql_Data_MySqlClient_MySqlDataReader.htm
        public static void LoadKeys(int d) {
            ABB myB = new ABB(null);
            MySqlConnection connection = CreateConnection.GetConnection();
            int collectedKey = 0;
            string myQuery = "SELECT randomKey FROM tbl_randomNumbers;";

            MySqlCommand query = new MySqlCommand(myQuery, connection);
            MySqlDataReader dataReader = query.ExecuteReader();

            while (dataReader.Read()) {
                collectedKey = dataReader.GetInt32(0);
                myB.insert(collectedKey);
                Console.WriteLine(collectedKey.ToString()); //<- Verificar salida de datos.
            }
            MessageBox.Show(myB.order(d));
            connection.Close();
        }

    }
}