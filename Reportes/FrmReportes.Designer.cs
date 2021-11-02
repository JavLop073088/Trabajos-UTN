
namespace Reportes
{
    partial class FrmReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.dtClientes2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes2 = new Reportes.dsClientes2();
            this.chkClientesNoActivos = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes2)).BeginInit();
            this.gbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtClientes2BindingSource
            // 
            this.dtClientes2BindingSource.DataMember = "dtClientes2";
            this.dtClientes2BindingSource.DataSource = this.dsClientes2;
            // 
            // dsClientes2
            // 
            this.dsClientes2.DataSetName = "dsClientes2";
            this.dsClientes2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkClientesNoActivos
            // 
            this.chkClientesNoActivos.AutoSize = true;
            this.chkClientesNoActivos.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientesNoActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkClientesNoActivos.Location = new System.Drawing.Point(30, 57);
            this.chkClientesNoActivos.Name = "chkClientesNoActivos";
            this.chkClientesNoActivos.Size = new System.Drawing.Size(218, 34);
            this.chkClientesNoActivos.TabIndex = 0;
            this.chkClientesNoActivos.Text = "Clientes no activos";
            this.chkClientesNoActivos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarReporte.Location = new System.Drawing.Point(47, 121);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(209, 73);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // rvClientes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtClientes2BindingSource;
            this.rvClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvClientes.LocalReport.ReportEmbeddedResource = "Reportes.rpteBanco.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(298, 1);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.ServerReport.BearerToken = null;
            this.rvClientes.Size = new System.Drawing.Size(1546, 1167);
            this.rvClientes.TabIndex = 2;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnGenerarReporte);
            this.gbClientes.Controls.Add(this.chkClientesNoActivos);
            this.gbClientes.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbClientes.Location = new System.Drawing.Point(1, 1);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(291, 224);
            this.gbClientes.TabIndex = 3;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Mostrar Clientes";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1840, 1168);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.rvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes2)).EndInit();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkClientesNoActivos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.BindingSource dtClientes2BindingSource;
        private dsClientes2 dsClientes2;
        private System.Windows.Forms.GroupBox gbClientes;
    }
}