using grafics;
using Project91.GUIForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioDeBusqueda {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //Ejemplo tomado de:
        //https://stackoverflow.com/questions/32084424/c-sharp-monogame-passing-arguments-on-startup/32086378#32086378
        [STAThread]
        static void Main() {
            var form = new MainForm();

            if (form.ShowDialog() == DialogResult.OK) {
                using var game = new Game1();
                    game.Run();
                Main();
            }            
            
        }
    }
}
