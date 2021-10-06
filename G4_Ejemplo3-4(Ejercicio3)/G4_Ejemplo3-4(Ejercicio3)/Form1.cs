using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_Ejemplo3_4_Ejercicio3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularlado_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtlado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(label2);
        }

        private void btncalcularradio_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtradio.Text);
            double A = 0;

            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(label4);
        }
    }
}
