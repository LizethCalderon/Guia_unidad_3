using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void TxtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            int v1, v2, r;
            v1 = int.Parse(TxtValor1.Text);
            v2 = int.Parse(TxtValor2.Text);

            r = v1 + v2;
            TxtResultado.Text = r.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
