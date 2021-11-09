
using BancoFront.Forms.Componentes;

namespace AppBanco.Forms
{
    partial class FrmTiposCuentas
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
            this.gboTiposCuentas = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new BancoFront.Forms.Componentes.RJButton();
            this.dgvTipoCuentas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gboCargarTiposCuentas = new System.Windows.Forms.GroupBox();
            this.txtTipoCuenta = new BancoFront.Forms.Componentes.RJTextBox();
            this.btnGuardar = new BancoFront.Forms.Componentes.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gboTiposCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCuentas)).BeginInit();
            this.gboCargarTiposCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboTiposCuentas
            // 
            this.gboTiposCuentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTiposCuentas.Controls.Add(this.dgvTipoCuentas);
            this.gboTiposCuentas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboTiposCuentas.Location = new System.Drawing.Point(53, 291);
            this.gboTiposCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboTiposCuentas.Name = "gboTiposCuentas";
            this.gboTiposCuentas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboTiposCuentas.Size = new System.Drawing.Size(661, 271);
            this.gboTiposCuentas.TabIndex = 0;
            this.gboTiposCuentas.TabStop = false;
            this.gboTiposCuentas.Text = "Tipos de Cuentas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(298, 579);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvTipoCuentas
            // 
            this.dgvTipoCuentas.AllowUserToAddRows = false;
            this.dgvTipoCuentas.AllowUserToDeleteRows = false;
            this.dgvTipoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colTipoCuenta,
            this.colActualizar,
            this.colEliminar});
            this.dgvTipoCuentas.Location = new System.Drawing.Point(27, 41);
            this.dgvTipoCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTipoCuentas.Name = "dgvTipoCuentas";
            this.dgvTipoCuentas.ReadOnly = true;
            this.dgvTipoCuentas.RowHeadersWidth = 51;
            this.dgvTipoCuentas.RowTemplate.Height = 24;
            this.dgvTipoCuentas.Size = new System.Drawing.Size(605, 209);
            this.dgvTipoCuentas.TabIndex = 0;
            this.dgvTipoCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoCuentas_CellContentClick);
            // 
            // colNro
            // 
            this.colNro.HeaderText = "nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Visible = false;
            this.colNro.Width = 125;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.HeaderText = "Tipo Cuenta";
            this.colTipoCuenta.MinimumWidth = 6;
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.ReadOnly = true;
            this.colTipoCuenta.Width = 300;
            // 
            // colActualizar
            // 
            this.colActualizar.HeaderText = "Actualizar";
            this.colActualizar.MinimumWidth = 6;
            this.colActualizar.Name = "colActualizar";
            this.colActualizar.ReadOnly = true;
            this.colActualizar.Text = "";
            this.colActualizar.UseColumnTextForButtonValue = true;
            this.colActualizar.Width = 125;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 125;
            // 
            // gboCargarTiposCuentas
            // 
            this.gboCargarTiposCuentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboCargarTiposCuentas.Controls.Add(this.txtTipoCuenta);
            this.gboCargarTiposCuentas.Controls.Add(this.btnGuardar);
            this.gboCargarTiposCuentas.Controls.Add(this.label1);
            this.gboCargarTiposCuentas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboCargarTiposCuentas.Location = new System.Drawing.Point(53, 50);
            this.gboCargarTiposCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboCargarTiposCuentas.Name = "gboCargarTiposCuentas";
            this.gboCargarTiposCuentas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboCargarTiposCuentas.Size = new System.Drawing.Size(661, 214);
            this.gboCargarTiposCuentas.TabIndex = 1;
            this.gboCargarTiposCuentas.TabStop = false;
            this.gboCargarTiposCuentas.Text = "Cargar Tipos de Cuentas";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoCuenta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTipoCuenta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipoCuenta.BorderSize = 2;
            this.txtTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoCuenta.Location = new System.Drawing.Point(34, 81);
            this.txtTipoCuenta.Multiline = false;
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Padding = new System.Windows.Forms.Padding(7);
            this.txtTipoCuenta.PasswordChar = false;
            this.txtTipoCuenta.Size = new System.Drawing.Size(250, 35);
            this.txtTipoCuenta.TabIndex = 3;
            this.txtTipoCuenta.Texts = "";
            this.txtTipoCuenta.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(34, 138);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 50);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cuenta:";
            // 
            // FrmTiposCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 659);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gboCargarTiposCuentas);
            this.Controls.Add(this.gboTiposCuentas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 706);
            this.MinimumSize = new System.Drawing.Size(788, 706);
            this.Name = "FrmTiposCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Cuentas";
            this.Load += new System.EventHandler(this.FrmTiposCuentas_Load);
            this.gboTiposCuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCuentas)).EndInit();
            this.gboCargarTiposCuentas.ResumeLayout(false);
            this.gboCargarTiposCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboTiposCuentas;
        private System.Windows.Forms.DataGridView dgvTipoCuentas;
        private System.Windows.Forms.GroupBox gboCargarTiposCuentas;
        private RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label1;
        private RJButton btnGuardar;
        private RJTextBox txtTipoCuenta;
        private RJButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCuenta;
        private System.Windows.Forms.DataGridViewButtonColumn colActualizar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}