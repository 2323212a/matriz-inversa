using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz_inversa
{
    public partial class matriz2x2 : Form
    {
        public matriz2x2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA11.Text);
            double b = double.Parse(txtA12.Text);
            double c = double.Parse(txtA21.Text);
            double d = double.Parse(txtA22.Text);

            double det = a * d - b * c;

            if (det == 0)
            {
                MessageBox.Show("La matriz no tiene inversa (determinante = 0)");
                return;
            }

            double invDet = 1 / det;

            double[,] inversa = new double[2, 2]
            {
        { d * invDet, -b * invDet },
        { -c * invDet, a * invDet }
            };

            MostrarMatrizInversa(inversa);
        }


        private void MostrarMatrizInversa(double[,] m)
        {
            lblResult00.Text = m[0, 0].ToString("F2");
            lblResult01.Text = m[0, 1].ToString("F2");
            lblResult10.Text = m[1, 0].ToString("F2");
            lblResult11.Text = m[1, 1].ToString("F2");
        }

        private void matriz2x2_Load(object sender, EventArgs e)
        {

        }
    }
}
