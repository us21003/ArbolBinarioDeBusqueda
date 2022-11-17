using System;
using grafics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project91;

//using System.Drawing;

namespace Project91
{
     class Ordentree
    {
        public int worth;
        public Ordentree Nleft;
        public Ordentree Nright;
        public Ordentree NodoFather;
        public int height;
        public Rectangle proof;
        private Dtree arbol;
        public Ordentree()
        {

        }
        public  Dtree Arbol
      
        {
            get { return arbol; }
            set { arbol = value; }
        }
        public Ordentree(int worthNuevo, Ordentree left, Ordentree right, Ordentree father)
        {
            worth = worthNuevo;
            Nleft = left;
            Nright = right;
            NodoFather = father;
            height = 0;
        }
        //Funcion para insertar un nuevo worth en el arbol AVL
        public Ordentree Insertar(int newvalue, Ordentree raiz)
        {
            if (raiz == null)
                raiz = new Ordentree(newvalue, null, null, null);//crea cada nodo
            else if (newvalue < raiz.worth)
            {
                raiz.Nleft = Insertar(newvalue, raiz.Nleft);
            }
            else if (newvalue > raiz.worth)
            {
                raiz.Nright = Insertar(newvalue, raiz.Nright);
            }
            else
            {
               // MessageBox.Show("Valor Existente en el Arbol", "Error", MessageBoxButtons.OK);
            }


            //Realiza las rotaciones simples o dobles segun el caso
            if (Heights(raiz.Nleft) - Heights(raiz.Nright) == 2)
            {
                if (newvalue < raiz.Nleft.worth)
                    raiz = Rotationleft(raiz);
                else
                    raiz = Rleftdouble(raiz);
            }
            if (Heights(raiz.Nright) - Heights(raiz.Nleft) == 2)
            {
                if (newvalue > raiz.Nright.worth)
                    raiz = Rrightssimple(raiz);
                else
                    raiz = Rrightdouble(raiz);
            }
            raiz.height = Max(Heights(raiz.Nleft), Heights(raiz.Nright)) + 1;
            return raiz;
        }
        //FUNCION DE PRUEBA PARA REALIZAR LAS ROTACIONES
        //Función para obtener que rama es mayor
        private static int Max(int lhs, int rhs)
        {
            return lhs > rhs ? lhs : rhs;
        }
        private static int Heights(Ordentree root)
        {
            return root == null ? -1 : root.height;
        }
        Ordentree nodoE, nodoP;
        public Ordentree Eliminar(int valorEliminar, ref Ordentree raiz)
        {
            if (raiz != null)
            {
                if (valorEliminar < raiz.worth)
                {
                    nodoE = raiz;
                    Eliminar(valorEliminar, ref raiz.Nleft);
                }
                else
                {
                    if (valorEliminar > raiz.worth)
                    {
                        nodoE = raiz;
                        Eliminar(valorEliminar, ref raiz.Nright);
                    }
                    else
                    {
                        //Posicionado sobre el elemento a eliminar
                        Ordentree Ndelete = raiz;

                       


                        if (Ndelete.Nright == null)
                        {
                            raiz = Ndelete.Nleft;
                            if (Heights(nodoE.Nleft) - Heights(nodoE.Nright) == 2)
                            {
                                //MessageBox.Show("nodoE" + nodoE.worth.ToString());
                                if (valorEliminar < nodoE.worth)
                                    nodoP = Rotationleft(nodoE);
                                else
                                    nodoE = Rrightssimple(nodoE);
                            }
                            if (Heights(nodoE.Nright) - Heights(nodoE.Nleft) == 2)
                            {
                                if (valorEliminar > nodoE.Nright.worth)
                                    nodoE = Rrightssimple(nodoE);
                                else
                                    nodoE = Rrightdouble(nodoE);
                                nodoP = Rrightssimple(nodoE);
                            }
                        }
                        else
                        {
                            if (Ndelete.Nleft == null)
                            {
                                raiz = Ndelete.Nright;
                            }
                            else
                            {
                                if (Heights(raiz.Nleft) - Heights(raiz.Nright) > 0)
                                {
                                    Ordentree auxiliarNodo = null;
                                    Ordentree auxiliar = raiz.Nleft;
                                    bool flag = false;
                                    while (auxiliar.Nright != null)
                                    {
                                        auxiliarNodo = auxiliar;
                                        auxiliar = auxiliar.Nright;
                                        flag = true;
                                    }
                                    raiz.worth = auxiliar.worth;
                                    Ndelete = auxiliar;
                                    if (flag == true)
                                    {
                                        auxiliarNodo.Nright = auxiliar.Nleft;
                                    }
                                    else
                                    {
                                        raiz.Nleft = auxiliar.Nleft;
                                    }
                                    //Realiza las rotaciones simples o dobles segun el caso
                                }
                                else
                                {
                                    if (Heights(raiz.Nright) - Heights(raiz.Nleft) > 0)
                                    {
                                        Ordentree auxiliarNodo = null;
                                        Ordentree auxiliar = raiz.Nright;
                                        bool flag = false;
                                        while (auxiliar.Nleft != null)
                                        {
                                            auxiliarNodo = auxiliar;
                                            auxiliar = auxiliar.Nleft;
                                            flag = true;
                                        }
                                        raiz.worth = auxiliar.worth;
                                        Ndelete = auxiliar;
                                        if (flag == true)
                                        {
                                            auxiliarNodo.Nleft = auxiliar.Nright;
                                        }
                                        else
                                        {
                                            raiz.Nright = auxiliar.Nright;
                                        }
                                    }
                                    else
                                    {
                                        if (Heights(raiz.Nright) - Heights(raiz.Nleft) == 0)
                                        {
                                            Ordentree auxiliarNodo = null;
                                            Ordentree auxiliar = raiz.Nleft;
                                            bool flag = false;
                                            while (auxiliar.Nright != null)
                                            {
                                                auxiliarNodo = auxiliar;
                                                auxiliar = auxiliar.Nright;
                                                flag = true;
                                            }
                                            raiz.worth = auxiliar.worth;
                                            Ndelete = auxiliar;
                                            if (flag == true)
                                            {
                                                auxiliarNodo.Nright = auxiliar.Nleft;
                                            }
                                            else
                                            {
                                                raiz.Nleft = auxiliar.Nleft;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show("Nodo inexistente en el arbol", "Error", MessageBoxButtons.OK);
            }
            return nodoP;
        }
        //Seccion de funciones de rotaciones
        //Rotacion Izquierda Simple
        private static Ordentree Rotationleft(Ordentree k2)
        {
            Ordentree k1 = k2.Nleft;
            k2.Nleft = k1.Nright;
            k1.Nright = k2;
            k2.height = Max(Heights(k2.Nleft), Heights(k2.Nright)) + 1;
            k1.height = Max(Heights(k1.Nleft), k2.height) + 1;
            return k1;
        }
        //Rotacion Derecha Simple
        private static Ordentree Rrightssimple(Ordentree k1)
        {
            Ordentree k2 = k1.Nright;
            k1.Nright = k2.Nleft;
            k2.Nleft = k1;
            k1.height = Max(Heights(k1.Nleft), Heights(k1.Nright)) + 1;
            k2.height = Max(Heights(k2.Nright), k1.height) + 1;
            return k2;
        }
        //Doble Rotacion Izquierda
        private static Ordentree Rleftdouble(Ordentree k3)
        {
            k3.Nleft = Rrightssimple(k3.Nleft);
            return Rotationleft(k3);
        }
        //Doble Rotacion Derecha
        private static Ordentree Rrightdouble(Ordentree k1)
        {
            k1.Nright = Rotationleft(k1.Nright);
            return Rrightssimple(k1);
        }
        //Funcion para obtener la height del arbol
        public int getAltura(Ordentree nodoActual)
        {
            if (nodoActual == null)
                return 0;
            else
                return 1 + Math.Max(getAltura(nodoActual.Nleft), getAltura(nodoActual.Nright));
        }
        //Buscar un worth en el arbol
        public static void Search(int valorBuscar, Ordentree raiz)
        {
            if (raiz != null)
            {
                if (valorBuscar < raiz.worth)
                {
                    Search(valorBuscar, raiz.Nleft);
                }
                else
                {
                    if (valorBuscar > raiz.worth)
                    {
                        Search(valorBuscar, raiz.Nright);
                    }
                }
            }
            ///else
               // MessageBox.Show("Valor no encontrado", "Error", MessageBoxButtons.OK);
        }
        /*++++++++++++FUNCIONES PARA DIBUJAR EL ÁRBOL +++++++++++++*/
        private const int Radio = 35;
        private const int DistanciaH = 140;
        private const int DistanciaV = 70;
        private int _coordenadaX;
        private int _coordenadaY;
        //Encuentra la posición en donde debe crearse el nodo.
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            _coordenadaY = (int)(ymin + Radio / 2);
            //obtiene la posición del Sub-Árbol left.
            if (Nleft != null)
            {
                Nleft.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((Nleft != null) && (Nright != null))
            {
                xmin += DistanciaH;
            }
            //Si existe el nodo right e left deja un espacio entre ellos.
            if (Nright != null)
            {
                Nright.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            // Posicion de nodos dercho e left.
            if (Nleft != null)
            {
                if (Nright != null)
                {
                    //centro entre los nodos.
                    _coordenadaX = (int)((Nleft._coordenadaX + Nright._coordenadaX) / 2);
                }
                else
                {
                    // no hay nodo right. centrar al nodo left.
                    aux1 = Nleft._coordenadaX;
                    Nleft._coordenadaX = _coordenadaX - 40;
                    _coordenadaX = aux1;
                }
            }
            else if (Nright != null)
            {
                aux2 = Nright._coordenadaX;
                //no hay nodo left.centrar al nodo right.
                Nright._coordenadaX = _coordenadaX + 40;
                _coordenadaX = aux2;
            }
            else
            {
                // Nodo hoja
                _coordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }
        // Dibuja las ramas de los nodos left y right
        public void DibujarRamas(GraphicsDeviceManager grafo, SpriteBatch sprite)
        {
            if (Nleft != null)
            {

                //arco
                MonoGame.Primitives2D.DrawLine(sprite, new Vector2(_coordenadaX, _coordenadaY), new Vector2(Nleft._coordenadaX, Nleft._coordenadaY), Color.Black);
                
                
                // grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Nleft.CoordenadaX,
               // Nleft.CoordenadaY);
                Nleft.DibujarRamas(grafo, sprite);
            }
            if (Nright != null)
            {   //arco
                MonoGame.Primitives2D.DrawLine(sprite, new Vector2(_coordenadaX, _coordenadaY), new Vector2(Nright._coordenadaX, Nright._coordenadaY), Color.Black);
                // grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Nright.CoordenadaX, Nright.CoordenadaY);
                Nright.DibujarRamas(grafo, sprite);
            }
        }
        //Dibuja el nodo en la posición especificada.

        //Dibuja el nodo en la posición especificada.
      


        public void DibujarNodo(GraphicsDeviceManager grafo,SpriteBatch sprite,int dato,SpriteFont font, Texture2D[] listaTexturas)
        {
            //Dibuja el contorno del nodo.
            Rectangle rect = new Rectangle(
            (int)(_coordenadaX - Radio / 2),
            (int)(_coordenadaY - Radio / 2),
            Radio, Radio);
            if (worth == dato)
            {

                MonoGame.Primitives2D.DrawCircle(sprite, new Vector2((int)(_coordenadaX - Radio / 2), (int)(_coordenadaY - Radio / 2)), Radio+2, 52,  Color.Red);
               
                for (int i = 0; i < 50; i++)
                  {
                    MonoGame.Primitives2D.DrawCircle(sprite, new Vector2((int)((_coordenadaX) - Radio / 2), (int)((_coordenadaY) - Radio / 2)), Radio-i, 52, Color.White);
                  }
                
                //grafo.FillEllipse(encuentro, rect);
               
            }
            else
            {
                MonoGame.Primitives2D.DrawCircle(sprite, new Vector2((int)(_coordenadaX - Radio / 2), (int)(_coordenadaY - Radio / 2)), Radio+2, 52, Color.Red);

                for (int i = 0; i < 50; i++)
                {
                    MonoGame.Primitives2D.DrawCircle(sprite, new Vector2((int)((_coordenadaX) - Radio  / 2), (int)((_coordenadaY) - Radio  / 2)), Radio - i, 52, Color.White);
                }

            }
            //letra
            //sprite.DrawString(font, worth.ToString(),new Vector2((int)(_coordenadaX - Radio / 2), (int)(_coordenadaY - Radio / 2)),Color.Black);
            string valor = worth.ToString();
            if (valor.Length == 1)
            {
                sprite.Draw(listaTexturas[0], new Rectangle((int)(_coordenadaX - Radio * 2), (int)(_coordenadaY - Radio), 70, 60), Color.Ivory);
                sprite.Draw(listaTexturas[worth], new Rectangle((int)(_coordenadaX - Radio - 10), (int)(_coordenadaY - Radio), 70, 60), Color.Ivory);
            }
            else
            {
                sprite.Draw(listaTexturas[Convert.ToInt32(valor[0].ToString())], new Rectangle((int)(_coordenadaX - Radio * 2), (int)(_coordenadaY - Radio), 70, 60), Color.Ivory);
                sprite.Draw(listaTexturas[Convert.ToInt32(valor[1].ToString())], new Rectangle((int)(_coordenadaX - Radio - 10), (int)(_coordenadaY - Radio), 70, 60), Color.Ivory);
            }
            //Dibuja los nodos hijos right e left.
            if (Nleft != null)
            {
                Nleft.DibujarNodo(grafo,sprite, dato,font, listaTexturas);
                
            }
            if (Nright != null)
            {
               Nright.DibujarNodo(grafo, sprite,dato,font, listaTexturas);
               
            }
        }
        
    }
}
