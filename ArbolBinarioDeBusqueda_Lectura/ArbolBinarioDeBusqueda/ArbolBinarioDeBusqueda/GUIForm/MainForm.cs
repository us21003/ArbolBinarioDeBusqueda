﻿using ArbolBinarioDeBusqueda.DBQueries;
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
using ArbolBinarioDeBusqueda.Logic;

namespace ArbolBinarioDeBusqueda {
    public partial class Form1 : Form {
        ABB miNodo = new ABB(null);
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

        private void btnShowPreorder_Click(object sender, EventArgs e)
        {
            LoadData.LoadKeys(1);
        }

        private void btnShowInorder_Click(object sender, EventArgs e)
        {
            LoadData.LoadKeys(2);
        }

        private void btnShowPostorder_Click(object sender, EventArgs e)
        {
            LoadData.LoadKeys(3);
        }
    }
}