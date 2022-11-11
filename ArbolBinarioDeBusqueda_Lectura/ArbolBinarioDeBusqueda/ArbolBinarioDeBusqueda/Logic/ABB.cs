using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda.Logic
{
    public class ABB
    {
        public Nodo root;
        public Nodo aux;
        private string inordenS;
        private string preordenS;
        private string postordenS;
        public ABB()
        {
            aux = new Nodo();
        }
        public ABB(Nodo r)
        {
            root = r;
        }
        public void insert(int fact)
        {
            if(root == null)
            {
                root = new Nodo(fact, null, null, null);
            }
            else
            {
                root = root.insert(fact, root);
            }
        }
        public string order(int d)
        {
            string tem = "";
            if(d == 1)
            {
                tem = preorden();
            }
            if(d == 2)
            {
                tem = inorden();
            }
            if(d == 3)
            {
                tem = postorden();
            }
            return tem;
        }
        public string inorden()
        {
            inordenS = "";
            if (root != null)
            {
                inorden2(root);
            }
            return inordenS;
        }
        private void inorden2(Nodo p)
        {
            if (p != null)
            {
                inorden2(p.left);
                inordenS += p.fact.ToString() + ",";
                inorden2(p.right);
            }
        }
        public string preorden()
        {
            preordenS = "";
            if (root != null)
            {
                preorden2(root);
            }
            return preordenS;
        }
        private void preorden2(Nodo p)
        {
            if (p != null)
            {
                preordenS += p.fact.ToString() + ",";
                preorden2(p.left);
                preorden2(p.right);
            }
        }
        public string postorden()
        {
            postordenS = "";
            if (root != null)
            {
                postorden2(root);
            }
            return postordenS;
        }
        private void postorden2(Nodo p)
        {
            if (p != null)
            {
                postorden2(p.left);
                postorden2(p.right);
                postordenS += p.fact.ToString() + ",";
            }
        }
    }
}
