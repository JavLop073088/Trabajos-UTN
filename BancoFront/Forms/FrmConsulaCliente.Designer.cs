
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
            this.txtNroDni = new BancoFront.Forms.Componentes.RJTextBox();
            this.txtApe = new BancoFront.Forms.Componentes.RJTextBox();
            this.txtNom = new BancoFront.Forms.Componentes.RJTextBox();
            this.txtNumCl = new BancoFront.Forms.Componentes.RJTextBox();
            this.lblNroClte = new System.Windows.Forms.Label();
            this.lblApeClte = new System.Windows.Forms.Label();
            this.lblNomClte = new System.Windows.Forms.Label();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
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
            this.gbFiltros.Controls.Add(this.txtNroDni);
            this.gbFiltros.Controls.Add(this.txtApe);
            this.gbFiltros.Controls.Add(this.txtNom);
            this.gbFiltros.Controls.Add(this.txtNumCl);
            this.gbFiltros.Controls.Add(this.lblNroClte);
            this.gbFiltros.Controls.Add(this.lblApeClte);
            this.gbFiltros.Controls.Add(this.lblNomClte);
            this.gbFiltros.Controls.Add(this.btnConsultar);
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
            // txtNroDni
            // 
            this.txtNroDni.BackColor = System.Drawing.SystemColors.Control;
            this.txtNroDni.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNroDni.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNroDni.BorderSize = 2;
            this.txtNroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNroDni.Location = new System.Drawing.Point(554, 47);
            this.txtNroDni.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNroDni.Multiline = false;
            this.txtNroDni.Name = "txtNroDni";
            this.txtNroDni.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNroDni.PasswordChar = false;
            this.txtNroDni.Size = new System.Drawing.Size(218, 39);
            this.txtNroDni.TabIndex = 23;
            this.txtNroDni.Texts = "";
            this.txtNroDni.UnderlinedStyle = true;
            // 
            // txtApe
            // 
            this.txtApe.BackColor = System.Drawing.SystemColors.Control;
            this.txtApe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApe.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApe.BorderSize = 2;
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApe.Location = new System.Drawing.Point(554, 145);
            this.txtApe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtApe.Multiline = false;
            this.txtApe.Name = "txtApe";
            this.txtApe.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtApe.PasswordChar = false;
            this.txtApe.Size = new System.Drawing.Size(218, 39);
            this.txtApe.TabIndex = 22;
            this.txtApe.Texts = "";
            this.txtApe.UnderlinedStyle = true;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNom.BorderSize = 2;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(147, 145);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNom.PasswordChar = false;
            this.txtNom.Size = new System.Drawing.Size(218, 39);
            this.txtNom.TabIndex = 21;
            this.txtNom.Texts = "";
            this.txtNom.UnderlinedStyle = true;
            // 
            // txtNumCl
            // 
            this.txtNumCl.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumCl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumCl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumCl.BorderSize = 2;
            this.txtNumCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumCl.Location = new System.Drawing.Point(147, 49);
            this.txtNumCl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNumCl.Multiline = false;
            this.txtNumCl.Name = "txtNumCl";
            this.txtNumCl.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNumCl.PasswordChar = false;
            this.txtNumCl.Size = new System.Drawing.Size(74, 39);
            this.txtNumCl.TabIndex = 20;
            this.txtNumCl.Texts = "";
            this.txtNumCl.UnderlinedStyle = true;
            // 
            // lblNroClte
            // 
            this.lblNroClte.AutoSize = true;
            this.lblNroClte.Location = new System.Drawing.Point(22, 56);
            this.lblNroClte.Name = "lblNroClte";
            this.lblNroClte.Size = new System.Drawing.Size(129, 25);
            this.lblNroClte.TabIndex = 19;
            this.lblNroClte.Text = "Nº de Cliente:";
            // 
            // lblApeClte
            // 
            this.lblApeClte.AutoSize = true;
            this.lblApeClte.Location = new System.Drawing.Point(460, 152);
            this.lblApeClte.Name = "lblApeClte";
            this.lblApeClte.Size = new System.Drawing.Size(88, 25);
            this.lblApeClte.TabIndex = 17;
            this.lblApeClte.Text = "Apellido:";
            // 
            // lblNomClte
            // 
            this.lblNomClte.AutoSize = true;
            this.lblNomClte.Location = new System.Drawing.Point(57, 152);
            this.lblNomClte.Name = "lblNomClte";
            this.lblNomClte.Size = new System.Drawing.Size(86, 25);
            this.lblNomClte.TabIndex = 15;
            this.lblNomClte.Text = "Nombre:";
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
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(460, 222);
            this.chkBaja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(138, 29);
            this.chkBaja.TabIndex = 9;
            this.chkBaja.Text = "Incluir Bajas";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 54);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.Text = "Consultar Clientes";
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
        private RJTextBox txtNroDni;
        private RJTextBox txtApe;
        private RJTextBox txtNom;
        private RJTextBox txtNumCl;
    }
}