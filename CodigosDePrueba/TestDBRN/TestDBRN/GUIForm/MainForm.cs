using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBRN.DBConnection;

namespace TestDBRN {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            Random r = new Random();
            int randomNumber = r.Next(1, 99);
            InsertToDB.Insert(randomNumber);
            string generatedKey = LoadFromDB.Load().ToString();
            MessageBox.Show(generatedKey);
        }
    }
}
