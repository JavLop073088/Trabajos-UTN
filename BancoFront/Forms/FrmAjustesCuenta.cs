using BancoBack.Dominio;
using BancoFront.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco.Forms
{
    public partial class FrmAjustesCuenta : Form
    {
        private Administrador oAdministrador = new Administrador();
        public FrmAjustesCuenta(Administrador oAdmin)
        {
            InitializeComponent();
            oAdministrador = oAdmin;
            CargarDatos(oAdministrador);
        }

        private void CargarDatos(Administrador oAdmin)
        {
            txtUsername.Texts = oAdmin.NomAdmin;
        }

        private void LimpiarCampos()
        {
            txtPassword.Texts = "";
            txtPasswordConfirm.Texts = "";
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Texts) || string.IsNullOrEmpty(txtPasswordConfirm.Texts))
            {
                MessageBox.Show("Debe ingresar valor de Password Valido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtPassword.Texts != txtPasswordConfirm.Texts)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            oAdministrador.PassAdmin = txtPassword.Texts;
            var upDateOK = await ActualizarAdminAsync(oAdministrador);

            if (upDateOK)
            {
                MessageBox.Show("El Administrador se ha Actualizado con éxito",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El Administrador no pudo Actualizarse, consulte a San Pedro",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> ActualizarAdminAsync(Administrador oAdministrador)
        {
            string url = "https://localhost:44317/api/Banco/actualizarAdmin";
            string json = JsonConvert.SerializeObject(oAdministrador);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }
    }
}
