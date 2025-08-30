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
        private Fraccion[,] inversaActual;

        public matriz2x2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA11.Text, out double a) ||
                !double.TryParse(txtA12.Text, out double b) ||
                !double.TryParse(txtA21.Text, out double c) ||
                !double.TryParse(txtA22.Text, out double d))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
                return;
            }

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
            // Guardar como fracciones
            inversaActual = new Fraccion[2, 2]
            {
                { Fraccion.DesdeDouble(m[0, 0]), Fraccion.DesdeDouble(m[0, 1]) },
                { Fraccion.DesdeDouble(m[1, 0]), Fraccion.DesdeDouble(m[1, 1]) }
            };

            lblResult00.Text = inversaActual[0, 0].ToString();
            lblResult01.Text = inversaActual[0, 1].ToString();
            lblResult10.Text = inversaActual[1, 0].ToString();
            lblResult11.Text = inversaActual[1, 1].ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtA11.Text = "";
            txtA12.Text = "";
            txtA21.Text = "";
            txtA22.Text = "";

            lblResult00.Text = "";
            lblResult01.Text = "";
            lblResult10.Text = "";
            lblResult11.Text = "";
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (inversaActual == null)
            {
                MessageBox.Show("Por favor calcula la matriz inversa primero.");
                return;
            }

            matriz_inversa_x_escalar2x2 formEscalar = new matriz_inversa_x_escalar2x2(inversaActual);
            formEscalar.Show();
            this.Hide();
        }
    }
}
