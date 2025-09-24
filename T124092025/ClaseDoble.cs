using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T124092025
{
    internal class ClaseDoble
    {

        NodoDoble Primero = null;
        NodoDoble Ultimo = null;

        public void InsertarInicio(int valor)
        {
            NodoDoble Nuevo = new NodoDoble();
            Nuevo.Dato = valor;

            if(Primero == null)
            {
                Nuevo.Sgt = null;
                Nuevo.Ante = null;
                Primero = Nuevo;
                Ultimo = Nuevo;

            }
            else
            {
                Nuevo.Sgt = Primero;
                Primero.Ante = Nuevo;
                Nuevo.Ante = null;
                Primero = Nuevo;

            }
        }

        public void InsertarFinal(int valor)
        {
            NodoDoble Nuevo = new NodoDoble();
            Nuevo.Dato = valor;

            if (Primero == null)
            {
                Nuevo.Sgt = null;
                Nuevo.Ante = null;
                Primero = Nuevo;
                Ultimo = Nuevo;

            }
            else
            {
                Nuevo.Sgt = null;
                Nuevo.Ante = Ultimo;
                Ultimo.Sgt = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void BDmostrar(ListBox lista)
        {
            NodoDoble Actualizar = Primero;

            while(Actualizar != null )
            {

                lista.Items.Add(Actualizar.Dato);
                Actualizar = Actualizar.Sgt;
                
            }
        }

        public void BDmodificar(int valor1 , int valor2)
        {
            NodoDoble Actualizar = Primero;
            bool Encontrado = false;

            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor1)
                {
                    Encontrado = true;
                    Actualizar.Dato = valor2;
                    MessageBox.Show("Valor Modificado");
                }
                Actualizar =Actualizar.Sgt;
            }
            if(Encontrado == false)
            {
                MessageBox.Show("No encontrado o insertado");
            }
        }

        public void BDbuscar(int valor)
        {
            NodoDoble Actualizar = Primero;
            bool encontrado = false;

            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor)
                {
                    encontrado = true;
                    MessageBox.Show("Si encontrado");
                }
                Actualizar = Actualizar.Sgt;
            }
            if(encontrado == false)
            {
                MessageBox.Show("No encontrado");
            }
        }
        public void BDcontar()
        {
            NodoDoble Actualizar = Primero;
            int cont = 0;

            while(Actualizar != null)
            {
                cont++;
                Actualizar = Actualizar.Sgt;
            }
            MessageBox.Show("Valores contados: " + cont);
        }

        public void BDeliminar(int valor)
        {
            NodoDoble Actualizar = Primero;
            NodoDoble Anterior = null;

            while(Actualizar != null)
            {
                if(Actualizar.Dato == valor)
                {
                    if(Actualizar == Primero)
                    {
                        Primero = Actualizar.Sgt;
                        Primero.Ante = null;

                    }
                    else if(Actualizar == Ultimo)
                    {
                        
                         
                        Ultimo = Anterior;
                        Ultimo.Sgt = null;
                    }
                    else
                    {
                        Anterior.Sgt = Actualizar.Sgt;
                        Actualizar.Sgt.Ante = Anterior;
                    }
                }
                Anterior = Actualizar;
                Actualizar = Actualizar.Sgt;
            }
        }
    }
}
