using System;
using System.Windows.Forms;

namespace matriz_inversa
{
    public partial class matrz3x3 : Form
    {
        private Fraccion[,] inversaFraccion; // Guardar la inversa como fracciones

        public matrz3x3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] A = new double[3, 3];
            double[,] I = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            try
            {
                A[0, 0] = double.Parse(txt00.Text);
                A[0, 1] = double.Parse(txt01.Text);
                A[0, 2] = double.Parse(txt02.Text);
                A[1, 0] = double.Parse(txt10.Text);
                A[1, 1] = double.Parse(txt11.Text);
                A[1, 2] = double.Parse(txt12.Text);
                A[2, 0] = double.Parse(txt20.Text);
                A[2, 1] = double.Parse(txt21.Text);
                A[2, 2] = double.Parse(txt22.Text);
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
                return;
            }

            // Método de Gauss-Jordan
            for (int i = 0; i < 3; i++)
            {
                double pivot = A[i, i];
                if (pivot == 0)
                {
                    MessageBox.Show("No se puede calcular la inversa (pivote cero).");
                    return;
                }

                // Normalizar fila
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] /= pivot;
                    I[i, j] /= pivot;
                }

                // Hacer ceros en la columna
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

            // Mostrar resultado en fracciones
            MostrarMatrizInversa(I);
        }

        private void MostrarMatrizInversa(double[,] m)
        {
            // Convertir a fracciones y guardar
            inversaFraccion = new Fraccion[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    inversaFraccion[i, j] = Fraccion.DesdeDouble(m[i, j]);
                }
            }

            // Mostrar en labels
            lbl00.Text = inversaFraccion[0, 0].ToString();
            lbl01.Text = inversaFraccion[0, 1].ToString();
            lbl02.Text = inversaFraccion[0, 2].ToString();

            lbl10.Text = inversaFraccion[1, 0].ToString();
            lbl11.Text = inversaFraccion[1, 1].ToString();
            lbl12.Text = inversaFraccion[1, 2].ToString();

            lbl20.Text = inversaFraccion[2, 0].ToString();
            lbl21.Text = inversaFraccion[2, 1].ToString();
            lbl22.Text = inversaFraccion[2, 2].ToString();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (inversaFraccion == null)
            {
                MessageBox.Show("Primero calcula la matriz inversa.");
                return;
            }

            // Captura los valores originales
            double[,] original = new double[3, 3]
            {
                { double.Parse(txt00.Text), double.Parse(txt01.Text), double.Parse(txt02.Text) },
                { double.Parse(txt10.Text), double.Parse(txt11.Text), double.Parse(txt12.Text) },
                { double.Parse(txt20.Text), double.Parse(txt21.Text), double.Parse(txt22.Text) }
            };
            double[] b = new double[3]
            {
                // Si tienes los TextBox para el vector B, cámbialos aquí
                0, 0, 0
            };

            this.Hide();
            matriz_inversa_x_escalares siguiente = new matriz_inversa_x_escalares(inversaFraccion, original, b);
            siguiente.ShowDialog();
            this.Close();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txt00.Text = "";
            txt01.Text = "";
            txt02.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txt20.Text = "";
            txt21.Text = "";
            txt22.Text = "";

            lbl00.Text = "";
            lbl01.Text = "";
            lbl02.Text = "";
            lbl20.Text = "";
            lbl21.Text = "";
            lbl22.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void matrz3x3_Load(object sender, EventArgs e)
        {

        }
    }
}
