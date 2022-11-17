using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda.Logic
{
    public class Nodo
    {
        public int fact { get; set; }
        public Nodo left { get; set; }
        public Nodo right { get; set; }
        public Nodo father { get; set; }
        public Nodo() { }
        public Nodo(int dato, Nodo l, Nodo r, Nodo f)
        {
            this.fact = dato;
            this.left = l;
            this.right = r;
            this.father = f;
        }
        public Nodo insert(int f, Nodo b)
        {
            if (b == null)
            {
                b = new Nodo(f, null, null, null);
            }
            else if (f < b.fact)
            {
                b.left = insert(f, b.left);
            }
            else if (f > b.fact)
            {
                b.right = insert(f, b.right);
            }
            return b;
        }
    }
}
