using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T124092025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista P =  new Lista();
        private void Binsetar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int valor) && valor > 0)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Ingresa un valor");

                }
                else
                {
                    //double estatura = Math.Floor((valor / 100.0) * 10) / 10.0;  //un decimal
                    double estatura = valor / 100.0; // dos decimales 
                    P.Insertar(estatura);
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese solo números enteros positivos");
            }
            

        }

        private void Bmostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            P.Mostrar(listBox1);
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            P.Buscar(int.Parse(textBox1.Text));
            textBox1.Clear(); 
        }

        private void Bmodificar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" && textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un valor");

            }
            else
            {
                P.Modificar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox1.Clear();
                textBox2.Clear();
            }
              
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un valor");

            }
            else
            {
                P.Eliminar(int.Parse(textBox3.Text));
                textBox3.Clear();
            }
                
        }

        private void Bcontar_Click(object sender, EventArgs e)
        {
            P.Contar();
        }


        ///lista Enlazada Doble
        ClaseDoble R = new ClaseDoble();
        private void BDinsertar_Click(object sender, EventArgs e)
        {
            R.InsertarInicio(int.Parse(textBox4.Text));
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R.InsertarFinal(int.Parse(textBox4.Text));
            textBox4.Clear();
        }

        private void BDmostrar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            R.BDmostrar(listBox2);
        }

        private void BDmodificar_Click(object sender, EventArgs e)
        {
            R.BDmodificar(int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            textBox4.Clear();
            textBox5.Clear();
        }

        private void BDcontar_Click(object sender, EventArgs e)
        {
            R.BDcontar();
        }

        private void BDbuscar_Click(object sender, EventArgs e)
        {
            R.BDbuscar(int.Parse(textBox4.Text));
            textBox4.Clear();
        }

        private void BDeliminar_Click(object sender, EventArgs e)
        {
            R.BDeliminar(int.Parse(textBox4.Text));
            textBox4.Clear();   
        }
    }
}
