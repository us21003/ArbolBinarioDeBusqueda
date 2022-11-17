using System.Windows.Forms;
using grafics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Project91 {
    internal class Dtree {
        public Ordentree Root;
        public Ordentree Aux;
        // Constructor.
        public Dtree() {
            Aux = new Ordentree();
        }
        public Dtree(Ordentree rootnew) {
            Root = rootnew;
        }
        // Agrega un nuevo worth al arbol.
        public void Insertar(int date) {
            if (Root == null)
                Root = new Ordentree(date, null, null, null);
            else
                Root = Root.Insertar(date, Root);
        }
        //Eliminar un worth del arbol
        public void Eliminar(int dato) {
            if (Root == null)
                Root = new Ordentree(dato, null, null, null);
            else
                Root.Eliminar(dato, ref Root);
        }
        private const int Radio = 35;
        private const int DistanciaH = 140;
        private const int DistanciaV = 70;
        private int _coordenadaX;
        private int _coordenadaY;
        public void PosicionNodoreocrrido(ref int xmin, ref int ymin) {
            _coordenadaY = (int)(ymin + Radio / 2);
            _coordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        //Dibuja el árbol
        public void DibujarArbol(GraphicsDeviceManager gra, SpriteBatch sprite, int dato, SpriteFont font, Texture2D[] listaTexturas) {
            int x = 300;
            int y = 100;
            if (Root == null) return;
            //Posicion de todos los Nodos.
            Root.PosicionNodo(ref x, y);
            //Dibuja los Enlaces entre nodos.
            Root.DibujarRamas(gra, sprite);
            //Dibuja todos los Nodos.
            Root.DibujarNodo(gra, sprite, dato, font, listaTexturas);
        }

        public int X1 = 250;
        public int Y2 = 75;
        public void restablecer_valores() {
            X1 = 100;
            Y2 = 75;
        }
        public void Search(int x) {
            if (Root == null)
                MessageBox.Show("Arbol AVL Vacío", "Error", MessageBoxButtons.OK);
            else
                Ordentree.Search(x, Root);
        }

    }
}
