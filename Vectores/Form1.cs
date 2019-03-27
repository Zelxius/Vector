using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        miVector vec;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void CrearBtn_Click(object sender, EventArgs e)
        {
            vec = new miVector(int.Parse(textBox2.Text));
        }

        private void LlenarBtn_Click(object sender, EventArgs e)
        {
            vec.Llenar(int.Parse(textBox3.Text));
        }

        private void MostrarBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = vec.Mostrar();
            label4.Visible = true;
            label4.Text = "Aquí está tu vector ;v";
        }

        private void GirarArribaBtn_Click(object sender, EventArgs e)
        {
            vec.GirarArriba();
            textBox1.Text = vec.Mostrar();
        }


        private void GirarAbajoBtn_Click_1(object sender, EventArgs e)
        {
            vec.GirarAbajo();
            textBox1.Text = vec.Mostrar();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void InvertirBtn_Click(object sender, EventArgs e)
        {
            vec.Invertir();
            textBox1.Text = vec.Mostrar();
        }
    }
}
