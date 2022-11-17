using grafics;
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
        [STAThread]
        static void Main() {
            var form = new Form1();

            if (form.ShowDialog() == DialogResult.OK) {
                using (var game = new Game1())
                    game.Run();
            }
        }
    }
}
