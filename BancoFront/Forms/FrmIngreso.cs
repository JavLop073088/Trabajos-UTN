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

namespace AppBanco.Forms
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void rjTxtUsername_Enter(object sender, EventArgs e)
        {
            if(rjTxtUsername.Texts == "USUARIO")
            {
                rjTxtUsername.Texts = "";
                rjTxtUsername.ForeColor = Color.LightGray;
            }
        }

        private void rjTxtUsername_Leave(object sender, EventArgs e)
        {
            if(rjTxtUsername.Texts == "")
            {
                rjTxtUsername.Texts = "USUARIO";
                rjTxtUsername.ForeColor = Color.DarkGray;
            }
        }

        private void rjTxtPassword_Enter(object sender, EventArgs e)
        {
            if (rjTxtPassword.Texts == "PASSWORD")
            {
                rjTxtPassword.Texts = "";
                rjTxtPassword.ForeColor = Color.LightGray;
                rjTxtPassword.PasswordChar = true;
            }
        }

        private void rjTxtPassword_Leave(object sender, EventArgs e)
        {
            if (rjTxtPassword.Texts == "")
            {
                rjTxtPassword.Texts = "PASSWORD";
                rjTxtPassword.ForeColor = Color.DarkGray;
                rjTxtPassword.PasswordChar = false;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
            this.Close();
        }
    }
}

namespace BancoFront
{
    class FrmLogin : Form
    {
    }
}