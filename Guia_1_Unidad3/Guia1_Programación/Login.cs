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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            String user, pass;
            user = TxtUser.Text.TrimEnd();
            pass = TxtPass.Text.TrimEnd();

            if ((user == "UTEC") && (pass == "PROGRA1"))
            {
                MessageBox.Show("Bienvenido");
            }
            else {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
