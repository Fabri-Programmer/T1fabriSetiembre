using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T124092025
{
    internal class NodoDoble
    {


        private int dato;
        private NodoDoble sgt;
        private NodoDoble ante;



        public int Dato { get => dato; set => dato = value; }
        internal NodoDoble Sgt { get => sgt; set => sgt = value; }

        internal NodoDoble Ante { get => ante; set => ante = value; }
    }
}
