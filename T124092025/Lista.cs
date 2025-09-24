using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

        public void Insertar(double valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            Nodo Validacion = Primero;

            while(Validacion != null)
            {
                if(Validacion.Dato == valor)
                {
                    MessageBox.Show("Ya existe, ingresa otro dato");
                    return;
                }
                Validacion = Validacion.Sgt;
            }

            if(valor > 0)
            {
                if (Primero == null)
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
            else
            {
                MessageBox.Show("Ingrese numero mayor a 0");
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
                    MessageBox.Show("Encontrado");
                }
                Actualizar = Actualizar.Sgt;
            }
            if(Encontrado == false)
            {
                MessageBox.Show("No encontrado");
            }
        }
        public void Modificar(int valor1, int valor2)
        {
            Nodo Actualizar = Primero;
            bool encontrado = false;
            Nodo Validacion = Primero;
            while(Validacion != null)
            {
                if (Validacion.Dato == valor2)
                {
                MessageBox.Show("Ya existe, ingresa otro dato");
                return;
                }
            Validacion = Validacion.Sgt;
            }

            while (Actualizar != null)
            {
                if(Actualizar.Dato == valor1)
                {
                    encontrado = true;
                    Actualizar.Dato = valor2;
                    MessageBox.Show($"El Valor: {valor1} Fue modifico por: {valor2} !!  ");
                }
                Actualizar = Actualizar.Sgt;
            }
            if(encontrado == false)
            {
                MessageBox.Show("Valor no encontrado para modificar");
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
                    if (Actualizar == Primero)
                    {
                        Primero = Primero.Sgt;
                    }
                    else if(Actualizar == Ultimo)
                    {
                        Anterior.Sgt = null;
                        Ultimo = Anterior;
                    }
                    else
                    {
                        Anterior.Sgt = Actualizar.Sgt;
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
            while( Actualizar != null )
            {
                cont++;
                Actualizar = Actualizar.Sgt;
            }
            MessageBox.Show($"Valores encontrados: {cont} ");
        }
    }
}
