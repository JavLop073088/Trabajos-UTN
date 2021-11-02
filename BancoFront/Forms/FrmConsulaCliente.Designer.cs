
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmConsulaCliente
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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.txtDNI = new BancoFront.Forms.Componentes.RJTextBox();
            this.dtpFechaHasta = new BancoFront.Forms.Componentes.RJDatePicker();
            this.dtpFechaDesde = new BancoFront.Forms.Componentes.RJDatePicker();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.txtDNI);
            this.gbFiltros.Controls.Add(this.dtpFechaHasta);
            this.gbFiltros.Controls.Add(this.dtpFechaDesde);
            this.gbFiltros.Controls.Add(this.chkBaja);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Location = new System.Drawing.Point(84, 147);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbFiltros.Size = new System.Drawing.Size(1539, 334);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Criterios de Busqueda";
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 20;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(1320, 242);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(179, 74);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.Control;
            this.txtDNI.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDNI.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDNI.BorderSize = 2;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.Location = new System.Drawing.Point(244, 157);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.Size = new System.Drawing.Size(474, 59);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaHasta.BorderSize = 0;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaHasta.Location = new System.Drawing.Point(1024, 42);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpFechaHasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(472, 36);
            this.dtpFechaHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFechaHasta.TabIndex = 11;
            this.dtpFechaHasta.TextColor = System.Drawing.Color.White;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaDesde.BorderSize = 0;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaDesde.Location = new System.Drawing.Point(244, 42);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpFechaDesde.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(472, 36);
            this.dtpFechaDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFechaDesde.TabIndex = 10;
            this.dtpFechaDesde.TextColor = System.Drawing.Color.White;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(244, 259);
            this.chkBaja.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(310, 36);
            this.chkBaja.TabIndex = 9;
            this.chkBaja.Text = "Incluir con Datos de Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha desde:";
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Location = new System.Drawing.Point(84, 526);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gbResultados.Size = new System.Drawing.Size(1539, 509);
            this.gbResultados.TabIndex = 9;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colFecha,
            this.colCBU,
            this.colCliente,
            this.colFechaBaja,
            this.colAcciones});
            this.dgvResultados.Location = new System.Drawing.Point(68, 42);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(1430, 430);
            this.dgvResultados.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Visible = false;
            this.colNro.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 125;
            // 
            // colCBU
            // 
            this.colCBU.HeaderText = "CBU";
            this.colCBU.MinimumWidth = 6;
            this.colCBU.Name = "colCBU";
            this.colCBU.ReadOnly = true;
            this.colCBU.Width = 125;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 125;
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.HeaderText = "Fecha Baja";
            this.colFechaBaja.MinimumWidth = 6;
            this.colFechaBaja.Name = "colFechaBaja";
            this.colFechaBaja.ReadOnly = true;
            this.colFechaBaja.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Text = "Ver Detalle";
            this.colAcciones.UseColumnTextForButtonValue = true;
            this.colAcciones.Width = 125;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(1492, 1066);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 66);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(216, 1066);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 66);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Location = new System.Drawing.Point(84, 1066);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 66);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmConsulaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1325);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmConsulaCliente";
            this.Text = "FrmConsulaCliente";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtDNI;
        private RJDatePicker dtpFechaHasta;
        private RJDatePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaBaja;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}