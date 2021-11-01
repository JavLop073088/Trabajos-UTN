
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
            this.txtNroClte = new BancoFront.Forms.Componentes.RJTextBox();
            this.lblNroClte = new System.Windows.Forms.Label();
            this.lblApeClte = new System.Windows.Forms.Label();
            this.txtAPellidoClte = new BancoFront.Forms.Componentes.RJTextBox();
            this.lblNomClte = new System.Windows.Forms.Label();
            this.txtNombreClte = new BancoFront.Forms.Componentes.RJTextBox();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.txtDNI = new BancoFront.Forms.Componentes.RJTextBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.gbFiltros.Controls.Add(this.txtNroClte);
            this.gbFiltros.Controls.Add(this.lblNroClte);
            this.gbFiltros.Controls.Add(this.lblApeClte);
            this.gbFiltros.Controls.Add(this.txtAPellidoClte);
            this.gbFiltros.Controls.Add(this.lblNomClte);
            this.gbFiltros.Controls.Add(this.txtNombreClte);
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.txtDNI);
            this.gbFiltros.Controls.Add(this.chkBaja);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFiltros.Location = new System.Drawing.Point(52, 92);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFiltros.Size = new System.Drawing.Size(947, 259);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Criterios de Busqueda";
            // 
            // txtNroClte
            // 
            this.txtNroClte.BackColor = System.Drawing.SystemColors.Control;
            this.txtNroClte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNroClte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNroClte.BorderSize = 2;
            this.txtNroClte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNroClte.Location = new System.Drawing.Point(157, 54);
            this.txtNroClte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNroClte.Multiline = false;
            this.txtNroClte.Name = "txtNroClte";
            this.txtNroClte.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNroClte.PasswordChar = false;
            this.txtNroClte.Size = new System.Drawing.Size(71, 39);
            this.txtNroClte.TabIndex = 18;
            this.txtNroClte.Texts = "";
            this.txtNroClte.UnderlinedStyle = true;
            // 
            // lblNroClte
            // 
            this.lblNroClte.AutoSize = true;
            this.lblNroClte.Location = new System.Drawing.Point(22, 63);
            this.lblNroClte.Name = "lblNroClte";
            this.lblNroClte.Size = new System.Drawing.Size(129, 25);
            this.lblNroClte.TabIndex = 19;
            this.lblNroClte.Text = "Nº de Cliente:";
            // 
            // lblApeClte
            // 
            this.lblApeClte.AutoSize = true;
            this.lblApeClte.Location = new System.Drawing.Point(460, 159);
            this.lblApeClte.Name = "lblApeClte";
            this.lblApeClte.Size = new System.Drawing.Size(88, 25);
            this.lblApeClte.TabIndex = 17;
            this.lblApeClte.Text = "Apellido:";
            // 
            // txtAPellidoClte
            // 
            this.txtAPellidoClte.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPellidoClte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAPellidoClte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAPellidoClte.BorderSize = 2;
            this.txtAPellidoClte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAPellidoClte.Location = new System.Drawing.Point(554, 152);
            this.txtAPellidoClte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAPellidoClte.Multiline = false;
            this.txtAPellidoClte.Name = "txtAPellidoClte";
            this.txtAPellidoClte.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtAPellidoClte.PasswordChar = false;
            this.txtAPellidoClte.Size = new System.Drawing.Size(196, 39);
            this.txtAPellidoClte.TabIndex = 16;
            this.txtAPellidoClte.Texts = "";
            this.txtAPellidoClte.UnderlinedStyle = true;
            // 
            // lblNomClte
            // 
            this.lblNomClte.AutoSize = true;
            this.lblNomClte.Location = new System.Drawing.Point(57, 159);
            this.lblNomClte.Name = "lblNomClte";
            this.lblNomClte.Size = new System.Drawing.Size(86, 25);
            this.lblNomClte.TabIndex = 15;
            this.lblNomClte.Text = "Nombre:";
            // 
            // txtNombreClte
            // 
            this.txtNombreClte.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreClte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreClte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreClte.BorderSize = 2;
            this.txtNombreClte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreClte.Location = new System.Drawing.Point(157, 152);
            this.txtNombreClte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreClte.Multiline = false;
            this.txtNombreClte.Name = "txtNombreClte";
            this.txtNombreClte.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNombreClte.PasswordChar = false;
            this.txtNombreClte.Size = new System.Drawing.Size(196, 39);
            this.txtNombreClte.TabIndex = 14;
            this.txtNombreClte.Texts = "";
            this.txtNombreClte.UnderlinedStyle = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 20;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(816, 205);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 46);
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
            this.txtDNI.Location = new System.Drawing.Point(554, 54);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.Size = new System.Drawing.Size(196, 39);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(460, 222);
            this.chkBaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(246, 29);
            this.chkBaja.TabIndex = 9;
            this.chkBaja.Text = "Incluir con Datos de Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI:";
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbResultados.Location = new System.Drawing.Point(52, 359);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbResultados.Size = new System.Drawing.Size(947, 288);
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
            this.ColNro,
            this.ColNom,
            this.ColApe,
            this.ColDni,
            this.ColBaja,
            this.ColAcc});
            this.dgvResultados.Location = new System.Drawing.Point(24, 58);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 29;
            this.dgvResultados.Size = new System.Drawing.Size(897, 188);
            this.dgvResultados.TabIndex = 0;
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Nº ";
            this.ColNro.MinimumWidth = 6;
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            this.ColNro.Width = 80;
            // 
            // ColNom
            // 
            this.ColNom.HeaderText = "Nombre";
            this.ColNom.MinimumWidth = 6;
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.Width = 150;
            // 
            // ColApe
            // 
            this.ColApe.HeaderText = "Apellido";
            this.ColApe.MinimumWidth = 6;
            this.ColApe.Name = "ColApe";
            this.ColApe.ReadOnly = true;
            this.ColApe.Width = 150;
            // 
            // ColDni
            // 
            this.ColDni.HeaderText = "DNI";
            this.ColDni.MinimumWidth = 6;
            this.ColDni.Name = "ColDni";
            this.ColDni.ReadOnly = true;
            this.ColDni.Width = 150;
            // 
            // ColBaja
            // 
            this.ColBaja.HeaderText = "Fecha Baja";
            this.ColBaja.MinimumWidth = 6;
            this.ColBaja.Name = "ColBaja";
            this.ColBaja.ReadOnly = true;
            this.ColBaja.Width = 200;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Acciones";
            this.ColAcc.MinimumWidth = 6;
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.ReadOnly = true;
            this.ColAcc.Text = "Detalle";
            this.ColAcc.UseColumnTextForButtonValue = true;
            this.ColAcc.Width = 110;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(874, 655);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 41);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(209, 655);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 41);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(52, 655);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 41);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmConsulaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 828);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private RJTextBox txtDNI;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private RJTextBox txtNroClte;
        private System.Windows.Forms.Label lblNroClte;
        private System.Windows.Forms.Label lblApeClte;
        private RJTextBox txtAPellidoClte;
        private System.Windows.Forms.Label lblNomClte;
        private RJTextBox txtNombreClte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBaja;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcc;
    }
}