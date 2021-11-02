
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSetCartera = new Reportes.dataSetCartera();
            this.dtCarteraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTipoCuenta = new Reportes.dataSetTipoCuenta();
            this.dtTotalesPorTipoCtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes = new Reportes.dataSetClientes();
            this.dtClientesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCartera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarteraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTotalesPorTipoCtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(271, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "dataSetCartera";
            reportDataSource7.Value = this.dtCarteraBindingSource;
            reportDataSource8.Name = "dataSetTipoCuenta";
            reportDataSource8.Value = this.dtTotalesPorTipoCtaBindingSource;
            reportDataSource9.Name = "dataSetClientes";
            reportDataSource9.Value = this.dtClientesActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.reporteBanco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(79, 204);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1374, 787);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSetCartera
            // 
            this.dataSetCartera.DataSetName = "dataSetCartera";
            this.dataSetCartera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtCarteraBindingSource
            // 
            this.dtCarteraBindingSource.DataMember = "dtCartera";
            this.dtCarteraBindingSource.DataSource = this.dataSetCartera;
            // 
            // dataSetTipoCuenta
            // 
            this.dataSetTipoCuenta.DataSetName = "dataSetTipoCuenta";
            this.dataSetTipoCuenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTotalesPorTipoCtaBindingSource
            // 
            this.dtTotalesPorTipoCtaBindingSource.DataMember = "dtTotalesPorTipoCta";
            this.dtTotalesPorTipoCtaBindingSource.DataSource = this.dataSetTipoCuenta;
            // 
            // dataSetClientes
            // 
            this.dataSetClientes.DataSetName = "dataSetClientes";
            this.dataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClientesActivosBindingSource
            // 
            this.dtClientesActivosBindingSource.DataMember = "dtClientesActivos";
            this.dtClientesActivosBindingSource.DataSource = this.dataSetClientes;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 1035);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmReportes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCartera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarteraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTotalesPorTipoCtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesActivosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dtCarteraBindingSource;
        private dataSetCartera dataSetCartera;
        private System.Windows.Forms.BindingSource dtTotalesPorTipoCtaBindingSource;
        private dataSetTipoCuenta dataSetTipoCuenta;
        private System.Windows.Forms.BindingSource dtClientesActivosBindingSource;
        private dataSetClientes dataSetClientes;
    }
}

