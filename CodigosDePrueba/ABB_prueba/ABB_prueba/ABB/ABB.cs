using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_prueba.ABB
{
    public class ABB
    {
        private Nodo raiz;
        private string inordenS;
        private string preordenS;
        private string postordenS;
        public ABB()
        {
            raiz = null;
            inordenS = "";
            preordenS = "";
            postordenS = "";
        }
        public void insertar(int d)
        {
            Nodo aux = new Nodo(d);
            if (raiz != null)
            {
                raiz = aux;
            }
        }
        private void insertar2(Nodo b, Nodo n)
        {
            if (b != null)
            {
                b = n;
            }
            if (n.dato < b.dato)
            {
                insertar2(b.izquierdo, n);
            }
            if (n.dato > b.dato)
            {
                insertar2(b.derecho, n);
            }
        }
        public string inorden()
        {
            inordenS = "";
            if (raiz != null)
            {
                inorden2(raiz);
            }
            return inordenS;
        }
        private void inorden2(Nodo p)
        {
            if (p != null)
            {
                inorden2(p.izquierdo);
                inordenS += p.dato.ToString() + ",";
                inorden2(p.derecho);
            }
        }
        public string preorden()
        {
            preordenS = "";
            if (raiz != null)
            {
                preorden2(raiz);
            }
            return preordenS;
        }
        private void preorden2(Nodo p)
        {
            if (p != null)
            {
                preordenS += p.dato.ToString() + ",";
                preorden2(p.izquierdo);
                preorden2(p.derecho);
            }
        }
        public string postorden()
        {
            postordenS = "";
            if (raiz != null)
            {
                postorden2(raiz);
            }
            return postordenS;
        }
        private void postorden2(Nodo p)
        {
            if (p != null)
            {
                postorden2(p.izquierdo);
                postorden2(p.derecho);
                postordenS += p.dato.ToString() + ",";
            }
        }
        public string getInorden()
        {
            return inordenS;
        }
    }
}
