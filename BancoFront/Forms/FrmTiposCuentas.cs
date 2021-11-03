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
    public partial class FrmTiposCuentas : Form
    {
        TipoCuenta oTipo = new TipoCuenta();

        public FrmTiposCuentas()
        {
            InitializeComponent();
        }

        private async void FrmTiposCuentas_Load(object sender, EventArgs e)
        {
            await CargarTiposCuentas();
        }
        //-------------------------------------------------------------------------------------------
        //Métodos de Eventos
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                oTipo.NombreTipo = txtTipoCuenta.Texts;

                var saveOK = await RegistrarTipoCuentaAsync(oTipo);

                if (saveOK)
                {
                    MessageBox.Show("El Tipo de Cuenta se ha registrado con éxito",
                        "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }
                else
                {
                    MessageBox.Show("El Tipo de Cuenta no pudo registrarse, consulte al Administrador",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvTipoCuentas.Rows.Clear();
            await CargarTiposCuentas();
            txtTipoCuenta.Texts = "";
        }
        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task CargarTiposCuentas()
        {
            string url = "https://localhost:44317/api/Banco/tipos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoCuenta> lst = JsonConvert.DeserializeObject<List<TipoCuenta>>(data);

            foreach (TipoCuenta oTipo in lst)
            {
                dgvTipoCuentas.Rows.Add(new object[]{oTipo.IdTipo,oTipo.NombreTipo});
            }
        }
        //-------------------------------------------------------------------------------------------
        private async Task<bool> RegistrarTipoCuentaAsync(TipoCuenta oTipo)
        {
            string url = "https://localhost:44317/api/Banco/altatipo";
            string json = JsonConvert.SerializeObject(oTipo);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        //Métodos Auxiliares:
        private bool ValidarCampo()
        {
            if (txtTipoCuenta.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Nombre de Cuenta",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoCuenta.Focus();
                return false;
            }
            return true;
        }
    }
}
