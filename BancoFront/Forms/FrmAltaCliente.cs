using BancoBack.Dominio;
using BancoFront.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco.Forms
{
    public enum Action
    {
        NUEVO,
        VER,
        EDITAR
    }
    public partial class FrmAltaCliente : Form
    {
        private Action modo;
        private int nro;

        Cliente oCliente = new Cliente();

        public FrmAltaCliente(Action modo, int nro)//*
        {
            InitializeComponent();
            this.modo = modo;
            this.nro = nro;          
        }

        private async void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            if (modo.Equals(Action.NUEVO))
            {
                txtCBU.Enabled = false;
                dtpFechaAlta.Enabled = false;
                txtCBU.Texts = GenerarCbu();

                await CargarComboAsync();
                await CargarNroClteAsync();
            }
            //------------------------------------------------------------
            if (modo.Equals(Action.VER))
            {
                BloquearCampos();               
                this.Text = "Visualizar Datos del Cliente";
                await CargarClienteCuentaAync(this.nro);
            }
            //------------------------------------------------------------
            if (modo.Equals(Action.EDITAR))
            {
                txtCBU.Enabled = false;
                dtpFechaAlta.Enabled = false;
                txtCBU.Texts = GenerarCbu();
                await CargarComboAsync();
                await CargarClienteCuentaAync(this.nro);
                this.Text = "Modificar Datos del Cliente";
                
            }
        }
        //-------------------------------------------------------------------------------------------
        //Métodos de Eventos
        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {         
            Cuenta oCuenta = new Cuenta();

            TipoCuenta oTipo = (TipoCuenta)cboTipoCuenta.SelectedItem;

            oCuenta.Cbu = txtCBU.Texts;
            oCuenta.Saldo = Convert.ToDouble(txtSaldo.Texts);
            oCuenta.UltimoMov = dtpFechaAlta.Value;          
            oCuenta.TipoCta = oTipo;

            oCliente.AgregarCuenta(oCuenta);

            dgvCuentas.Rows.Add(new object[] { "", oTipo.NombreTipo, oCuenta.Cbu, oCuenta.Saldo, oCuenta.UltimoMov });

            CalcularTotalCartera();
            txtCBU.Texts = GenerarCbu();
        }
        //-------------------------------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            {
                if (modo.Equals(Action.NUEVO))
                    LimpiarCampos();
                if (modo.Equals(Action.EDITAR))
                    this.Dispose();
            }          
        }
        //-------------------------------------------------------------------------------------------
        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentCell.ColumnIndex == 5)
            {
                oCliente.QuitarCuenta(dgvCuentas.CurrentRow.Index);
                dgvCuentas.Rows.Remove(dgvCuentas.CurrentRow);
                CalcularTotalCartera();
            }
        }
        //-------------------------------------------------------------------------------------------
        private async void btnAceptar_ClickAsync(object sender, EventArgs e)
        {
            if (modo.Equals(Action.NUEVO))
            {
                if (ValidarCampos())
                {
                    oCliente.NomCliente = txtNombre.Texts;
                    oCliente.ApeCliente = txtApellido.Texts;
                    oCliente.dni = Convert.ToInt32(txtDNI.Texts);

                    var saveOK = await RegistrarClienteAsync(oCliente);

                    if (saveOK)
                    {
                        MessageBox.Show("El Cliente se ha Registrado con éxito",
                            "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no pudo Registrarse, consulte al Administrador",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (modo.Equals(Action.EDITAR))
            {
                if (ValidarCampos())
                {
                    oCliente.NroCliente = Convert.ToInt32(lblNroClte.Text);
                    oCliente.NomCliente = txtNombre.Texts;
                    oCliente.ApeCliente = txtApellido.Texts;
                    oCliente.dni = Convert.ToInt32(txtDNI.Texts);

                    var upDateOK = await ActualizarClienteAsync(oCliente);
                    
                    if (upDateOK)
                    {
                        MessageBox.Show("El Cliente se ha Actualizado con éxito",
                            "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no pudo Actualizarse, consulte al Administrador",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task<bool> RegistrarClienteAsync(Cliente oCliente)
        {           
            string url = "https://localhost:44317/api/Banco/registro";
            string json = JsonConvert.SerializeObject(oCliente);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        private async Task<bool> ActualizarClienteAsync(Cliente oCliente)
        {
            string url = "https://localhost:44317/api/Banco/actualizar";
            string json = JsonConvert.SerializeObject(oCliente);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }
        //-------------------------------------------------------------------------------------------
        private async Task CargarNroClteAsync()
        {
            string url = "https://localhost:44317/api/Banco/numero";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            int nro = JsonConvert.DeserializeObject<int>(data);

            lblNroClte.Text = nro.ToString();
        }
        //-------------------------------------------------------------------------------------------
        private async Task CargarComboAsync()
        {
            string url = "https://localhost:44317/api/Banco/tipos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<TipoCuenta> lst = JsonConvert.DeserializeObject<List<TipoCuenta>>(data);

            cboTipoCuenta.DataSource = lst;
            cboTipoCuenta.DisplayMember = "NombreTipo";
            cboTipoCuenta.ValueMember = "IdTipo";        
        }
        //-------------------------------------------------------------------------------------------
        private async Task CargarClienteCuentaAync(int nro)
        {
            string url = "https://localhost:44317/api/Banco/" + nro.ToString();
            var resultado = await ClienteSingleton.GetInstance().GetAsync(url);
            this.oCliente = JsonConvert.DeserializeObject<Cliente>(resultado);

            lblNroClte.Text = oCliente.NroCliente.ToString();
            txtNombre.Texts = oCliente.NomCliente;
            txtApellido.Texts = oCliente.ApeCliente;
            txtDNI.Texts = oCliente.dni.ToString();

            dgvCuentas.Rows.Clear();
            foreach (Cuenta oCta in oCliente.Cartera)
            {
                dgvCuentas.Rows.Add(new object[] { "", oCta.TipoCta.NombreTipo,oCta.Cbu, oCta.Saldo, oCta.UltimoMov });
            }
            CalcularTotalCartera();
        }
        //-------------------------------------------------------------------------------------------
        //Métodos Auxiliares:
        private string GenerarCbu()
        {
            var numeros = "0123456789";
            var cadenaCBU = new char[22];
            var random = new Random();

            for (int i = 0; i < cadenaCBU.Length; i++)
            {
                cadenaCBU[i] = numeros[random.Next(numeros.Length)];
            }
            var resultado = new String(cadenaCBU);

            return resultado;
        }
        //-------------------------------------------------------------------------------------------
        private void CalcularTotalCartera()
        {
            double total = oCliente.CalcularTotalCartera();
            lblTotal.Text = total.ToString();
        }
        //-------------------------------------------------------------------------------------------
        private bool ValidarCampos()
        {
            if (dgvCuentas.Rows.Count == 0)
            {
                MessageBox.Show("Debe Registrar al menos una Cuenta", 
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAgregarCuenta.Focus();
                return false;
            }
            if (txtNombre.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Nombre de Cliente", 
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Apellido de Cliente", 
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDNI.Texts) 
                || !int.TryParse(txtDNI.Texts, out _) 
                || Convert.ToInt32(txtDNI.Texts) <= 0
                || txtDNI.Texts.Length < 8)
            {
                MessageBox.Show("Debe Ingresar un DNI válido, de al menos 8 dígitos", 
                    "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDNI.Focus();
                return false;
            }
            if (txtSaldo.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Saldo de Cuenta mayor o igual a Cero", 
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            return true;
        }
        //-------------------------------------------------------------------------------------------
        private async void LimpiarCampos()
        {
            txtNombre.Texts = "";
            txtApellido.Texts = "";
            txtDNI.Texts = "";
            cboTipoCuenta.SelectedIndex = 0;
            txtSaldo.Texts = "0";
            GenerarCbu();
            dgvCuentas.Rows.Clear();
            lblTotal.Text = "0";
            txtNombre.Focus();
            await CargarNroClteAsync();
        }
        //-------------------------------------------------------------------------------------------
        private void BloquearCampos()
        {
            gpBoxCartera.Enabled = false;
            gpBoxCliente.Enabled = false;
            spBoxCuenta.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        //-------------------------------------------------------------------------------------------
    }
}
