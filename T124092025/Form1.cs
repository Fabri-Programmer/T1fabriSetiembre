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
            P.Insertar(int.Parse(textBox1.Text));
            textBox1.Clear();
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
            P.Modificar(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Beliminar_Click(object sender, EventArgs e)
        { 
            P.Eliminar(int.Parse(textBox3.Text));
            textBox3.Clear();
        }

        private void Bcontar_Click(object sender, EventArgs e)
        {
            P.Contar();
        }
    }
}
