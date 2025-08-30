using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz_inversa
{
    public partial class matriz_inversa_x_escalares : Form
    {
        private Fraccion[,] inversaFraccion;

        public matriz_inversa_x_escalares()
        {
            InitializeComponent();
        }

        public matriz_inversa_x_escalares(Fraccion[,] inversa)
        {
            InitializeComponent();
            inversaFraccion = inversa;
            MostrarInversa();
        }

        private void MostrarInversa()
        {
            lblResult00.Text = inversaFraccion[0, 0].ToString();
            lblResult01.Text = inversaFraccion[0, 1].ToString();
            lblResult02.Text = inversaFraccion[0, 2].ToString();

            lblResult10.Text = inversaFraccion[1, 0].ToString();
            lblResult11.Text = inversaFraccion[1, 1].ToString();
            lblResult12.Text = inversaFraccion[1, 2].ToString();

            lblResult20.Text = inversaFraccion[2, 0].ToString();
            lblResult21.Text = inversaFraccion[2, 1].ToString();
            lblResult22.Text = inversaFraccion[2, 2].ToString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double b0) ||
                !double.TryParse(textBox2.Text, out double b1) ||
                !double.TryParse(textBox3.Text, out double b2))
            {
                MessageBox.Show("Por favor, ingresa valores válidos para los escalares.");
                return;
            }

            double x0 = inversaFraccion[0, 0].ADecimal() * b0 +
                        inversaFraccion[0, 1].ADecimal() * b1 +
                        inversaFraccion[0, 2].ADecimal() * b2;

            double x1 = inversaFraccion[1, 0].ADecimal() * b0 +
                        inversaFraccion[1, 1].ADecimal() * b1 +
                        inversaFraccion[1, 2].ADecimal() * b2;

            double x2 = inversaFraccion[2, 0].ADecimal() * b0 +
                        inversaFraccion[2, 1].ADecimal() * b1 +
                        inversaFraccion[2, 2].ADecimal() * b2;

            Fraccion fx0 = Fraccion.DesdeDouble(x0);
            Fraccion fx1 = Fraccion.DesdeDouble(x1);
            Fraccion fx2 = Fraccion.DesdeDouble(x2);

            lblX1.Text = $"x₁ = {fx0} ({x0:F2})";
            lblX2.Text = $"x₂ = {fx1} ({x1:F2})";
            lblX3.Text = $"x₃ = {fx2} ({x2:F2})";
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\Public\procedimiento_matriz3x3.txt";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(" === MATRIZ INVERSA 3x3 ===");
                for (int i = 0; i < 3; i++)
                {
                    sw.WriteLine($"{inversaFraccion[i, 0]}\t{inversaFraccion[i, 1]}\t{inversaFraccion[i, 2]}");
                }

                sw.WriteLine("\n=== VECTOR B ===");
                sw.WriteLine($"b₁ = {textBox1.Text}");
                sw.WriteLine($"b₂ = {textBox2.Text}");
                sw.WriteLine($"b₃ = {textBox3.Text}");

                sw.WriteLine("\n=== RESULTADOS ===");
                sw.WriteLine(lblX1.Text);
                sw.WriteLine(lblX2.Text);
                sw.WriteLine(lblX3.Text);
            }

            MessageBox.Show("Procedimiento guardado en resultado_3x3.txt");
        }

        private void btnabrir_Click_1(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\Public\procedimiento_matriz3x3.txt";

            if (File.Exists(ruta))
            {
                System.Diagnostics.Process.Start("notepad.exe", ruta);
            }
            else
            {
                MessageBox.Show("El archivo no existe. Primero guarda el procedimiento.");
            }
        }
    }
}