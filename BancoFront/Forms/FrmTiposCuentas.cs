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

        List<TipoCuenta> lista = null;

        public FrmTiposCuentas()
        {
            InitializeComponent();
        }

        private void FrmTiposCuentas_Load(object sender, EventArgs e)
        {
            LlenarGrilla();          
        }

        //-------------------------------------------------------------------------------------------
        //Métodos de Eventos
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
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
            LlenarGrilla();
            txtTipoCuenta.Texts = "";
        }
        //-------------------------------------------------------------------------------------------
        private async void dgvTipoCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTipo = Convert.ToInt32(dgvTipoCuentas.CurrentRow.Cells["ColNro"].Value.ToString());
            bool ok = false;

            if (dgvTipoCuentas.CurrentCell.ColumnIndex == 2)//btnActualizar
            {
                if (ValidarCampos())
                {
                    oTipo.IdTipo = idTipo;
                    oTipo.NombreTipo = txtTipoCuenta.Texts;
                    ok = await ActualizarTipoAsync(oTipo);
                    if(ok) MessageBox.Show("Tipo de Cuenta Actualizada", 
                        "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El Tipo de Cuenta no pudo Actualizarse",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
                             
            }
            if (dgvTipoCuentas.CurrentCell.ColumnIndex == 3)//btnEliminar
            {
                ok = await EliminarTipoAsync(idTipo);
                if (ok) MessageBox.Show("Tipo de Cuenta Eliminada con éxito",
                     "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El Tipo de Cuenta no pudo Eliminarse",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvTipoCuentas.Rows.Clear();
            LlenarGrilla();
            txtTipoCuenta.Texts = "";
        }
        //-------------------------------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task<List<TipoCuenta>> CargarTiposCuentas()
        {
            string url = "https://localhost:44317/api/Banco/tipos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoCuenta> lst = JsonConvert.DeserializeObject<List<TipoCuenta>>(data);

            return lst;
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
        private async Task<bool> ActualizarTipoAsync(TipoCuenta oTipo)
        {
            string url = "https://localhost:44317/api/Banco/modiftipo";
            string json = JsonConvert.SerializeObject(oTipo);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        private async Task<bool> EliminarTipoAsync(int idTipo)
        {
            string url = "https://localhost:44317/api/Banco/borrar/" + idTipo.ToString();
            var result = await ClienteSingleton.GetInstance().DeleteAsync(url);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        //Métodos Auxiliares:
        private bool ValidarCampos()
        {
            if (txtTipoCuenta.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Nombre de Cuenta",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoCuenta.Focus();
                return false;
            }
            //---------------------------------------------------------------------
            foreach (TipoCuenta item in lista)
            {
                if(item.NombreTipo == txtTipoCuenta.Texts)
                {
                    MessageBox.Show("El nombre de Cuenta ya Existe",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoCuenta.Focus();
                    return false;
                }
            }
            return true;
        }
        //-------------------------------------------------------------------------------------------
        private async void LlenarGrilla()
        {
            lista = await CargarTiposCuentas();
            foreach (TipoCuenta oTipo in lista)
            {
                dgvTipoCuentas.Rows.Add(new object[] { oTipo.IdTipo, oTipo.NombreTipo });
            }
        }

        
    }
}
