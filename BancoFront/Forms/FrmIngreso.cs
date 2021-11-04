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
using BancoBack.Dominio;
using BancoBack.Servicios;
using Newtonsoft.Json;
using BancoFront.Client;

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

        private async void btnIngreso_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();
            object valor1 = DBNull.Value, valor2 = DBNull.Value;


            if (rjTxtUsername.Texts != "USUARIO")
            {
                valor1 = rjTxtUsername.Texts.ToString();
                filtros.Add(new Parametro("@username", valor1));
            } else
            {
                MessageBox.Show("Debe Ingresar un Nombre de usuario valido");
                return;
            }

            if (rjTxtPassword.Texts != "PASSWORD")
            {
                valor1 = rjTxtUsername.Texts.ToString();
                filtros.Add(new Parametro("@password", valor1));
            }
            else
            {
                MessageBox.Show("Debe Ingresar un Password de usuario valido");
                return;
            }

            // Validacion API
            Administrador admin = new Administrador();
            admin.NomAdmin = rjTxtUsername.Texts;
            admin.PassAdmin = rjTxtPassword.Texts;
            int idAdmin = await CargarConsultaAdmin(admin);

            if(idAdmin > 0)
            {
                // Abrir Form Principal
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal(idAdmin);
                principal.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Datos incorrectos o usuario inexistente");
                return;
            }
        }

        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task<int> CargarConsultaAdmin(Administrador oAdmin)
        {
            string filtrosJson = JsonConvert.SerializeObject(oAdmin);
            string url = "https://localhost:44317/api/Banco/consultaAdmin";

            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, filtrosJson);

            int res = JsonConvert.DeserializeObject<int>(resultado);

            return res;
        }
    }
}

