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
    public partial class Suma1 : Form
    {
        public Suma1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int x, i, suma=0;
            listBox1.Items.Clear();
            x = int.Parse(TxtN.Text);
            for (i = 1;i <= x;i++)
            {
                suma = suma + i;
                if (checkBox1.Checked==true)
                {
                    listBox1.Items.Add("sumando "+i+" suma parcial: "+suma);
                }
            }
            listBox1.Items.Add("La suma total es: "+suma);
        }
    }
}
