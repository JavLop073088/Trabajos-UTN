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

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            this.rvClientes.RefreshReport();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-8EMNHC7Q;Initial Catalog=db_Banco;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SP_REPORTE_CUENTAS", cnn);

            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            if (chkClientesNoActivos.Checked == true)
                cmd.Parameters.AddWithValue("@baja", "S");
            else
                cmd.Parameters.AddWithValue("@baja", "N");

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            rvClientes.LocalReport.DataSources.Clear();
            rvClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabla));
            rvClientes.RefreshReport();

            cnn.Close();
        }
    }
}
