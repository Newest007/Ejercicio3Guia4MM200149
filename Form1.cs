using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3___Guía4_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtlado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlado.Clear();
            txtradio.Clear();
            txtresultado1.Clear();
            txtresultado2.Clear();
            txtresultado3.Clear();
            txtdigmenor.Clear();
            txtdigmayor.Clear();

        }

        private void txtradio_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtresultado3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdigmenor_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double DMa = double.Parse(txtdigmayor.Text);
            double DMe = double.Parse(txtdigmenor.Text);
            double A = 0;
            Rombo rombo = new Rombo(A, DMa, DMe);
            rombo.CalcularArea(txtresultado3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double R = double.Parse(txtradio.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(txtresultado2);
        }

        private void btncalcuadrado_Click(object sender, EventArgs e)
        {

            double L = double.Parse(txtlado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(txtresultado1);
        }

        private void txtlado_Enter(object sender, EventArgs e)
        {
        }
    }
}
