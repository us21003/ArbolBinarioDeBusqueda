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
using System.Runtime.InteropServices;

namespace ArbolBinarioDeBusqueda {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e) {

            GenerateKey();
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
            //int randomNumber = 
            return r.Next(0, 99);
        }

        private void GenerateKey() {

            //Generamos un nuevo numero aleatorio:
            int generatedKey = GetRandomNumnber();

            //Comprobamos si la clave no existe:
            if (!SearchKeys.CheckIfKeyExistInTable(generatedKey)) {

                //Si no existe, la guardamos:
                InsertToDB.SaveKey(generatedKey);
                MessageBox.Show("Clave generada correctamente");
            } else {
                //Si no existe, aplicamos recursividad a la funcion:
                Console.WriteLine("Clave repetida: " + generatedKey.ToString()); //<- imprimir clave generada (acciones de comprobacion).
                GenerateKey();
            }
        }

        private void btnShowPreorder_Click(object sender, EventArgs e) {
            LoadData.LoadKeys(1);
        }

        private void btnShowInorder_Click(object sender, EventArgs e) {
            LoadData.LoadKeys(2);
        }

        private void btnShowPostorder_Click(object sender, EventArgs e) {
            LoadData.LoadKeys(3);
        }        

        private void btnExit_Click(object sender, EventArgs e) {

            //Pedir confirmacion para cerrar el programa
            //Ejemplo tomado de: https://stackoverflow.com/questions/7955244/how-do-i-show-a-messagebox-prompt-when-the-user-has-clicked-the-cross-in-the-tit
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Application.Exit();
            } else {
                MessageBox.Show("Cancelado");
            }            
        }

        //Agregar evento de arrastre con el mouse al panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMainForm_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
