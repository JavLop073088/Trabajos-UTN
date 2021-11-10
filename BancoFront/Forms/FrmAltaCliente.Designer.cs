
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmAltaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpBoxCliente = new System.Windows.Forms.GroupBox();
            this.lblNroClte = new System.Windows.Forms.Label();
            this.txtDNI = new BancoFront.Forms.Componentes.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new BancoFront.Forms.Componentes.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new BancoFront.Forms.Componentes.RJTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.spBoxCuenta = new System.Windows.Forms.GroupBox();
            this.btnAgregarCuenta = new FontAwesome.Sharp.IconButton();
            this.dtpFechaAlta = new BancoFront.Forms.Componentes.RJDatePicker();
            this.cboTipoCuenta = new BancoFront.Forms.Componentes.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new BancoFront.Forms.Componentes.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCBU = new BancoFront.Forms.Componentes.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpBoxCartera = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCartera = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.gpBoxCliente.SuspendLayout();
            this.spBoxCuenta.SuspendLayout();
            this.gpBoxCartera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxCliente
            // 
            this.gpBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpBoxCliente.Controls.Add(this.lblNroClte);
            this.gpBoxCliente.Controls.Add(this.txtDNI);
            this.gpBoxCliente.Controls.Add(this.label2);
            this.gpBoxCliente.Controls.Add(this.txtApellido);
            this.gpBoxCliente.Controls.Add(this.label1);
            this.gpBoxCliente.Controls.Add(this.txtNombre);
            this.gpBoxCliente.Controls.Add(this.lblNombre);
            this.gpBoxCliente.Controls.Add(this.lblNroCliente);
            this.gpBoxCliente.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBoxCliente.Location = new System.Drawing.Point(66, 74);
            this.gpBoxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCliente.Name = "gpBoxCliente";
            this.gpBoxCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCliente.Size = new System.Drawing.Size(311, 468);
            this.gpBoxCliente.TabIndex = 4;
            this.gpBoxCliente.TabStop = false;
            this.gpBoxCliente.Text = "Datos del Cliente";
            // 
            // lblNroClte
            // 
            this.lblNroClte.AutoSize = true;
            this.lblNroClte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroClte.Location = new System.Drawing.Point(148, 58);
            this.lblNroClte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroClte.Name = "lblNroClte";
            this.lblNroClte.Size = new System.Drawing.Size(32, 31);
            this.lblNroClte.TabIndex = 12;
            this.lblNroClte.Text = "--";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.Control;
            this.txtDNI.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDNI.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDNI.BorderSize = 2;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.Location = new System.Drawing.Point(32, 341);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.Size = new System.Drawing.Size(250, 39);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNI: ";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(32, 253);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(250, 39);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(32, 166);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(250, 39);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 141);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 25);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(32, 64);
            this.lblNroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(108, 25);
            this.lblNroCliente.TabIndex = 5;
            this.lblNroCliente.Text = "Cliente Nº: ";
            // 
            // spBoxCuenta
            // 
            this.spBoxCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spBoxCuenta.Controls.Add(this.btnAgregarCuenta);
            this.spBoxCuenta.Controls.Add(this.dtpFechaAlta);
            this.spBoxCuenta.Controls.Add(this.cboTipoCuenta);
            this.spBoxCuenta.Controls.Add(this.label6);
            this.spBoxCuenta.Controls.Add(this.txtSaldo);
            this.spBoxCuenta.Controls.Add(this.label5);
            this.spBoxCuenta.Controls.Add(this.label4);
            this.spBoxCuenta.Controls.Add(this.txtCBU);
            this.spBoxCuenta.Controls.Add(this.label3);
            this.spBoxCuenta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spBoxCuenta.Location = new System.Drawing.Point(660, 74);
            this.spBoxCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spBoxCuenta.Name = "spBoxCuenta";
            this.spBoxCuenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spBoxCuenta.Size = new System.Drawing.Size(432, 468);
            this.spBoxCuenta.TabIndex = 9;
            this.spBoxCuenta.TabStop = false;
            this.spBoxCuenta.Text = "Datos de la Cuenta";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregarCuenta.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCuenta.IconSize = 25;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(234, 409);
            this.btnAgregarCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(181, 50);
            this.btnAgregarCuenta.TabIndex = 21;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFechaAlta.BorderSize = 2;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaAlta.Location = new System.Drawing.Point(36, 346);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaAlta.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(304, 35);
            this.dtpFechaAlta.SkinColor = System.Drawing.SystemColors.Control;
            this.dtpFechaAlta.TabIndex = 20;
            this.dtpFechaAlta.TextColor = System.Drawing.Color.Black;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTipoCuenta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoCuenta.BorderSize = 1;
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoCuenta.ForeColor = System.Drawing.Color.DimGray;
            this.cboTipoCuenta.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTipoCuenta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTipoCuenta.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTipoCuenta.Location = new System.Drawing.Point(36, 166);
            this.cboTipoCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipoCuenta.MinimumSize = new System.Drawing.Size(200, 38);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoCuenta.Size = new System.Drawing.Size(274, 44);
            this.cboTipoCuenta.TabIndex = 19;
            this.cboTipoCuenta.Texts = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Alta: ";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaldo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSaldo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSaldo.BorderSize = 2;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldo.Location = new System.Drawing.Point(36, 255);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSaldo.Multiline = false;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtSaldo.PasswordChar = false;
            this.txtSaldo.Size = new System.Drawing.Size(274, 39);
            this.txtSaldo.TabIndex = 17;
            this.txtSaldo.Texts = "0";
            this.txtSaldo.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saldo $: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de Cuenta: ";
            // 
            // txtCBU
            // 
            this.txtCBU.BackColor = System.Drawing.SystemColors.Control;
            this.txtCBU.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCBU.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCBU.BorderSize = 2;
            this.txtCBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCBU.Location = new System.Drawing.Point(36, 75);
            this.txtCBU.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCBU.Multiline = false;
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtCBU.PasswordChar = false;
            this.txtCBU.Size = new System.Drawing.Size(274, 39);
            this.txtCBU.TabIndex = 13;
            this.txtCBU.Texts = "";
            this.txtCBU.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "CBU: ";
            // 
            // gpBoxCartera
            // 
            this.gpBoxCartera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpBoxCartera.Controls.Add(this.lblTotal);
            this.gpBoxCartera.Controls.Add(this.lblTotalCartera);
            this.gpBoxCartera.Controls.Add(this.dgvCuentas);
            this.gpBoxCartera.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBoxCartera.Location = new System.Drawing.Point(66, 564);
            this.gpBoxCartera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCartera.Name = "gpBoxCartera";
            this.gpBoxCartera.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBoxCartera.Size = new System.Drawing.Size(1026, 289);
            this.gpBoxCartera.TabIndex = 17;
            this.gpBoxCartera.TabStop = false;
            this.gpBoxCartera.Text = "Cartera de Cuentas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(865, 245);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 31);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0,00";
            // 
            // lblTotalCartera
            // 
            this.lblTotalCartera.AutoSize = true;
            this.lblTotalCartera.Location = new System.Drawing.Point(683, 250);
            this.lblTotalCartera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCartera.Name = "lblTotalCartera";
            this.lblTotalCartera.Size = new System.Drawing.Size(174, 25);
            this.lblTotalCartera.TabIndex = 9;
            this.lblTotalCartera.Text = "TOTAL CARTERA: $";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTipo,
            this.ColCBU,
            this.Col,
            this.ColFecha,
            this.ColAcc});
            this.dgvCuentas.Location = new System.Drawing.Point(26, 57);
            this.dgvCuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.Size = new System.Drawing.Size(983, 170);
            this.dgvCuentas.TabIndex = 5;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 90;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo ";
            this.ColTipo.MinimumWidth = 6;
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            this.ColTipo.Width = 270;
            // 
            // ColCBU
            // 
            this.ColCBU.HeaderText = "CBU";
            this.ColCBU.MinimumWidth = 6;
            this.ColCBU.Name = "ColCBU";
            this.ColCBU.ReadOnly = true;
            this.ColCBU.Width = 235;
            // 
            // Col
            // 
            this.Col.HeaderText = "Saldo";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.Width = 140;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Ultimo Movimiento";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 204;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Acción";
            this.ColAcc.MinimumWidth = 6;
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.ReadOnly = true;
            this.ColAcc.Text = "Quitar";
            this.ColAcc.ToolTipText = "Quitar";
            this.ColAcc.UseColumnTextForButtonValue = true;
            this.ColAcc.Width = 80;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(959, 862);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 50);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 25;
            this.btnAceptar.Location = new System.Drawing.Point(785, 862);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 50);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_ClickAsync);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 966);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpBoxCartera);
            this.Controls.Add(this.spBoxCuenta);
            this.Controls.Add(this.gpBoxCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gpBoxCliente.ResumeLayout(false);
            this.gpBoxCliente.PerformLayout();
            this.spBoxCuenta.ResumeLayout(false);
            this.spBoxCuenta.PerformLayout();
            this.gpBoxCartera.ResumeLayout(false);
            this.gpBoxCartera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.GroupBox spBoxCuenta;
        private System.Windows.Forms.GroupBox gpBoxCartera;
        private System.Windows.Forms.Label lblTotalCartera;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private RJTextBox txtNombre;
        private RJTextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private RJTextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private RJTextBox txtSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RJTextBox txtCBU;
        private System.Windows.Forms.Label label3;
        private RJComboBox cboTipoCuenta;
        private RJDatePicker dtpFechaAlta;
        private FontAwesome.Sharp.IconButton btnAgregarCuenta;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.Label lblNroClte;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcc;
        private System.Windows.Forms.TextBox txtFecha;
    }
}