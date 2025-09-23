using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T124092025
{
    internal class Nodo
    {

        private int dato;
        private Nodo sgt;

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Sgt { get => sgt; set => sgt = value; }
    }
}
