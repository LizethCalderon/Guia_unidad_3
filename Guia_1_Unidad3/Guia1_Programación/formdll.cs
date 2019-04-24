using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Guia_1
{
    public partial class formdll : Form
    {
        private int tiempo;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0xF170;
        [DllImport("user32.dll")]
        private extern static void Sendmessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("winmm")]
        public static extern void mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, long hwndCallback);
        public formdll()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Sendmessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
            //El 2 es para apagar
        }

        private void Btn2_Click(object sender, EventArgs e)
        {

        }
    }
}
