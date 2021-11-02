using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reportes
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-4IJU6EJ\SQLEXPRESS;Initial Catalog=db_Banco;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SP_REPORTE_CUENTAS2", cnn);
            
            cnn.Open();

            cmd.Parameters.AddWithValue("@fecha_desde", dateTimePicker1.Value);   //lo saca del dateTimePicker y se lo asigna al parametro
            cmd.Parameters.AddWithValue("@fecha_hasta", dateTimePicker2.Value);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dataSetCartera", tabla));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dataSetTipoCuenta", tabla));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dataSetClientes", tabla));

            reportViewer1.RefreshReport();

            
            cnn.Close();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
