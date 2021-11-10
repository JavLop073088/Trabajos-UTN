using BancoBack.Dominio;
using BancoBack.Servicios;
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
    public partial class FrmConsulaCliente : Form
    {
        public FrmConsulaCliente()
        {
            InitializeComponent();
            
        }
        //-------------------------------------------------------------------------------------------
        //Métodos de Eventos
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            List<Parametro> filtros = new List<Parametro>();

            object valor1 = DBNull.Value, valor2 = DBNull.Value, valor3 = DBNull.Value, valor4 = DBNull.Value;
            string conBaja = "N";
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtNumCl.Texts))
                valor1 = Convert.ToInt32(txtNumCl.Texts);
            filtros.Add(new Parametro("@nroClte", valor1));
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtNom.Texts))
                valor2 = txtNom.Texts;
            filtros.Add(new Parametro("@nomClte", valor2));
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtApe.Texts))
                valor3 = txtApe.Texts;
            filtros.Add(new Parametro("@apeClte", valor3));
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtNroDni.Texts))
                valor4 = Convert.ToInt32(txtNroDni.Texts);
            filtros.Add(new Parametro("@dniClte", valor4));
            //----------------------------------------------
            if (chkBaja.Checked)
                conBaja = "S";
            filtros.Add(new Parametro("@dato_baja", conBaja));
            //----------------------------------------------

            List<Cliente> lista = await CargarConsultaClteAsync(filtros);

            foreach (Cliente oCliente in lista)
            {
                dgvResultados.Rows.Add(new object[]{
                    oCliente.NroCliente,
                    oCliente.NomCliente,
                    oCliente.ApeCliente,
                    oCliente.dni,
                    oCliente.GetFechaBajaFormato()
                }) ;              
            }

            if (dgvResultados.RowCount == 0)
                MessageBox.Show("No Existen Coincidencias para los Parámetros de su Consulta",
                                "Información",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-------------------------------------------------------------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        //-------------------------------------------------------------------------------------------
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow;
            if(row != null)
            {
                int numeroClte = Int32.Parse(row.Cells["ColNro"].Value.ToString());

                if (MessageBox.Show("Seguro que desea dar de Baja al Cliente seleccionado?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = await BajaClienteAsync(numeroClte);

                    if (respuesta)
                    {
                        MessageBox.Show("El Cliente ha sido dado de Baja",
                                        "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("La Baja de Cliente no pudo realizarse",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarCampos();
        }
        //-------------------------------------------------------------------------------------------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow;
            if (row != null)
            {
                int nroClte = Convert.ToInt32(dgvResultados.CurrentRow.Cells["ColNro"].Value.ToString());
                FrmAltaCliente form = new FrmAltaCliente(Action.EDITAR, nroClte);
                form.ShowDialog();

            }           
        }
        //-------------------------------------------------------------------------------------------
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvResultados.CurrentCell.ColumnIndex == 5)
            {
                int nroClte = Convert.ToInt32(dgvResultados.CurrentRow.Cells["ColNro"].Value.ToString());
                FrmAltaCliente form = new FrmAltaCliente(Action.VER,nroClte);
                form.ShowDialog();
            }            
        }
        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task<List<Cliente>> CargarConsultaClteAsync(List<Parametro> filtros)
        {
            List<Cliente> listClte = new List<Cliente>();

            string filtrosJson = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44317/api/Banco/consultaparam";

            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, filtrosJson);

            listClte = JsonConvert.DeserializeObject<List<Cliente>>(resultado);

            return listClte;
        }
        //-------------------------------------------------------------------------------------------
        private async Task<bool> BajaClienteAsync(int numeroClte)
        {
            string url = "https://localhost:44317/api/Banco/" + numeroClte.ToString();           
            var result = await ClienteSingleton.GetInstance().DeleteAsync(url);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        //Métodos Auxiliares:
        private void LimpiarCampos()
        {
            txtApe.Texts = txtNom.Texts = txtNumCl.Texts = txtNroDni.Texts = "";           
            chkBaja.Checked = false;
            dgvResultados.Rows.Clear();
            btnConsultar.Focus();
        }

        
    }
}
