using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T124092025
{
    internal class Lista
    {

        Nodo Primero = null;
        Nodo Ultimo = null;

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
                Ultimo.Sgt = null;
            }
            else
            {
                Ultimo.Sgt = nuevo;
                Ultimo = nuevo;
                Ultimo.Sgt = null;
            }

        }
        public void Mostrar(ListBox lista)
        {
            Nodo Actualizar = Primero;

            while(Actualizar != null)
            {
                lista.Items.Add(Actualizar.Dato);
                Actualizar = Actualizar.Sgt;
            }

        }

        public void Buscar(int valor)
        {
            Nodo Actualizar = Primero;
            bool Encontrado = false;

            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor)
                {
                    Encontrado = true;
                    MessageBox.Show("Se encontro en la lista");
                }
                Actualizar = Actualizar.Sgt;
            }
            if(Encontrado == false)
            {
                MessageBox.Show("No se encontro en la lista");
            }
        }
        public void Modificar(int valor1 , int valor2)
        {
            Nodo Actualizar = Primero;
            bool encontrar = false;
            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor1)
                {
                    encontrar = true;
                    Actualizar.Dato = valor2;
                }
                Actualizar = Actualizar.Sgt;
            }
            if(encontrar == false)
            {
                MessageBox.Show("No hay numero para modificar");
            }
        }

        public void Eliminar(int valor)
        {
            Nodo Actualizar = Primero;
            Nodo Anterior = null;

            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor)
                {
                    if(Actualizar == Primero)
                    {
                        Primero = Primero.Sgt; 
                        //Mueve el puntero Primero al siguiente nodo.

                        //Básicamente, el segundo nodo pasa a ser el nuevo inicio de la lista.
                    }
                    else if(Actualizar == Ultimo)
                    {
                        Anterior.Sgt = null;
                        Ultimo = Anterior;
                       // El nodo anterior ahora apunta a null(marcando el fin de la lista).
                        //Ultimo se actualiza para que sea el nodo anterior.
                    }
                    else
                    {
                        Anterior.Sgt = Actualizar.Sgt;
                       
                        //El nodo anterior salta al nodo que sigue después del actual.
                        //De esta forma, el nodo actual queda fuera de la cadena.
                    }
                    
                }
                Anterior = Actualizar;
                Actualizar = Actualizar.Sgt;
            }
        }
        public void Contar()
        {
            Nodo Actualizar = Primero;
            int cont = 0;

            while(Actualizar != null)
            {
                cont++;
                Actualizar = Actualizar.Sgt;

            }
            MessageBox.Show("Elementos contados: " + cont);

        }
    }
}
