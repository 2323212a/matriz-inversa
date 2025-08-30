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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmatriz2x2_Click(object sender, EventArgs e)
        {
            matriz2x2 form = new matriz2x2();
            form.ShowDialog();

        }

        private void btnmatriz3x3_Click(object sender, EventArgs e)
        {

        }

        private void btnmatriz3x3_Click_1(object sender, EventArgs e)
        {
            matrz3x3 form = new matrz3x3();
            form.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
