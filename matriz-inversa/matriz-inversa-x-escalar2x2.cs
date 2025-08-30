using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matriz_inversa;

namespace matriz_inversa
{
    public partial class matriz_inversa_x_escalar2x2 : Form
    {
        private Fraccion[,] inversaFraccion;
        private double escalar1, escalar2;
        private Fraccion resultadoX1, resultadoX2;

        public matriz_inversa_x_escalar2x2()
        {
            InitializeComponent();
        }

        public matriz_inversa_x_escalar2x2(Fraccion[,] inversa)
        {
            InitializeComponent();
            inversaFraccion = inversa;

            // Mostrar la inversa en los labels
            lblResult00.Text = inversaFraccion[0, 0].ToString();
            lblResult01.Text = inversaFraccion[0, 1].ToString();
            lblResult10.Text = inversaFraccion[1, 0].ToString();
            lblResult11.Text = inversaFraccion[1, 1].ToString();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtescalar.Text, out escalar1) || !double.TryParse(txtescalar2.Text, out escalar2))
            {
                MessageBox.Show("Por favor, ingresa valores válidos para los escalares.");
                return;
            }

            double x1 = inversaFraccion[0, 0].ADecimal() * escalar1 + inversaFraccion[0, 1].ADecimal() * escalar2;
            double x2 = inversaFraccion[1, 0].ADecimal() * escalar1 + inversaFraccion[1, 1].ADecimal() * escalar2;

            resultadoX1 = Fraccion.DesdeDouble(x1);
            resultadoX2 = Fraccion.DesdeDouble(x2);

            lblresultado.Text = $"x₁ = {resultadoX1} ({x1:F2})";
            lblresultado2.Text = $"x₂ = {resultadoX2} ({x2:F2})";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = @"C:\Users\Public\procedimiento_matriz2x2.txt";

                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine("=== MATRIZ INVERSA ===");
                    sw.WriteLine($"{inversaFraccion[0, 0],10}  {inversaFraccion[0, 1],10}");
                    sw.WriteLine($"{inversaFraccion[1, 0],10}  {inversaFraccion[1, 1],10}");

                    sw.WriteLine("\n=== VECTOR B ===");
                    sw.WriteLine($"b₁ = {escalar1}");
                    sw.WriteLine($"b₂ = {escalar2}");

                    sw.WriteLine("\n=== MULTIPLICACIÓN INVERSA × VECTOR ===");
                    sw.WriteLine($"x₁ = ({inversaFraccion[0, 0]} × {escalar1}) + ({inversaFraccion[0, 1]} × {escalar2}) = {resultadoX1} ({resultadoX1.ADecimal():F2})");
                    sw.WriteLine($"x₂ = ({inversaFraccion[1, 0]} × {escalar1}) + ({inversaFraccion[1, 1]} × {escalar2}) = {resultadoX2} ({resultadoX2.ADecimal():F2})");

                    sw.WriteLine("\n=== RESULTADOS ===");
                    sw.WriteLine($"x₁ = {resultadoX1} ({resultadoX1.ADecimal():F2})");
                    sw.WriteLine($"x₂ = {resultadoX2} ({resultadoX2.ADecimal():F2})");

                    sw.WriteLine("\n--- Fin del procedimiento ---");
                }

                MessageBox.Show("Procedimiento guardado exitosamente en: \n" + ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo:\n" + ex.Message);
            }
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\Public\procedimiento_matriz2x2.txt";

            if (File.Exists(ruta))
            {
                System.Diagnostics.Process.Start("notepad.exe", ruta);
            }
            else
            {
                MessageBox.Show("El archivo no existe. Primero guarda el procedimiento.");
            }
        }

        private void btnfinalizar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}