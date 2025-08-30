using System;
using System.Windows.Forms;

namespace matriz_inversa
{
    public partial class matrz3x3 : Form
    {
        public matrz3x3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] A = new double[3, 3];
            double[,] I = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            // Leer datos
            A[0, 0] = double.Parse(txt00.Text);
            A[0, 1] = double.Parse(txt01.Text);
            A[0, 2] = double.Parse(txt02.Text);
            A[1, 0] = double.Parse(txt10.Text);
            A[1, 1] = double.Parse(txt11.Text);
            A[1, 2] = double.Parse(txt12.Text);
            A[2, 0] = double.Parse(txt20.Text);
            A[2, 1] = double.Parse(txt21.Text);
            A[2, 2] = double.Parse(txt22.Text);

            // Gauss-Jordan
            for (int i = 0; i < 3; i++)
            {
                double pivot = A[i, i];
                if (pivot == 0)
                {
                    MessageBox.Show("No se puede calcular la inversa (pivote cero).");
                    return;
                }

                for (int j = 0; j < 3; j++)
                {
                    A[i, j] /= pivot;
                    I[i, j] /= pivot;
                }
                for (int k = 0; k < 3; k++)
                {
                    if (k == i) continue;
                    double factor = A[k, i];
                    for (int j = 0; j < 3; j++)
                    {
                        A[k, j] -= factor * A[i, j];
                        I[k, j] -= factor * I[i, j];
                    }
                }
            }

            MostrarMatrizInversa(I);
        }
        private void MostrarMatrizInversa(double[,] m)
        {
            lbl00.Text = m[0, 0].ToString("F2");
            lbl01.Text = m[0, 1].ToString("F2");
            lbl02.Text = m[0, 2].ToString("F2");

            lbl10.Text = m[1, 0].ToString("F2");
            lbl11.Text = m[1, 1].ToString("F2");
            lbl12.Text = m[1, 2].ToString("F2");

            lbl20.Text = m[2, 0].ToString("F2");
            lbl21.Text = m[2, 1].ToString("F2");
            lbl22.Text = m[2, 2].ToString("F2");
        }
    }
}