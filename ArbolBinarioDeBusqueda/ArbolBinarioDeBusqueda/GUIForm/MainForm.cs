using ArbolBinarioDeBusqueda.DBQueries;
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

namespace ArbolBinarioDeBusqueda {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e) {
            InsertToDB.SaveKey(GetRandomNumnber());
            MessageBox.Show("Clave generada correctamente");
            LoadData.LoadKeys();
        }

        private void btnSearchKey_Click(object sender, EventArgs e) {
            if (txtSearchKey.Text.Equals("")) {
                MessageBox.Show("Error: debe proveer un numero a buscar");
            } else {
                int keyToSearch = Int32.Parse(txtSearchKey.Text);
                string result = SearchKeys.PrintOutResult(keyToSearch);
                MessageBox.Show(result);
                txtSearchKey.Clear();
            }
        }

        private void txtSearchKey_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
                txtSearchKey.Clear();
            }
        }

        private int GetRandomNumnber() {
            Random r = new Random();
            int randomNumber = r.Next(0, 99);
            return randomNumber;
        }
    }
}
