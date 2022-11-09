using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Random r = new Random();
            int generatedKey = r.Next(0, 99);
            Insert.InsertToDB(generatedKey);
            MySqlDataReader dr = LoadData.LoadContent();

            while (dr.Read()) {
                MessageBox.Show("Value: " + dr.GetString("randomKey"));
            }
        }
    }
}
