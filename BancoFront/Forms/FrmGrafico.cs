using AppBanco.Dominio;
using BancoFront;
using BancoFront.Client;
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco.Forms
{
    public partial class FrmGrafico : Form
    {
        public FrmGrafico()
        {
            InitializeComponent();
        }
        
        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Meses",
                Labels = new[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ingresos",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;




            // Grafico Torta
            CargarTortaAsync();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            List<Revenue> lst = new List<Revenue>();
            DataTable table = new DataTable();

            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-8EMNHC7Q;Initial Catalog=pruebagraficos;Integrated Security=True");

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM ingresos", cnn);
                cmd.CommandType = CommandType.Text;


                table.Load(cmd.ExecuteReader());
                //mappear los registros como objetos del dominio:

                foreach (DataRow row in table.Rows)
                {
                    //Por cada registro creamos un objeto del dominio
                    Revenue oIngresos = new Revenue();
                    oIngresos.Year = Convert.ToInt32(row["years"].ToString());
                    oIngresos.Month = Convert.ToInt32(row["months"].ToString());
                    oIngresos.Value = Convert.ToDouble(row["total"].ToString());


                    lst.Add(oIngresos);
                    //MessageBox.Show(oIngresos.Year.ToString());
                    //MessageBox.Show(oIngresos.Month.ToString());
                    //MessageBox.Show(oIngresos.Value.ToString());
                }

                cnn.Close();
            }
            catch (SqlException)
            {
                lst = null;
            }

            //foreach (var v in lst)
            //{
            //    MessageBox.Show(v.Year.ToString());
            //    MessageBox.Show(v.Month.ToString());
            //    MessageBox.Show(v.Value.ToString());
            //}

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var years = (from o in lst as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in lst as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                    {
                        value = data.SingleOrDefault().Value;
                    }
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
        }

        private async Task CargarTortaAsync()
        {
            string url = "https://localhost:44317/api/Banco/tipos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Revenue> lst = JsonConvert.DeserializeObject<List<Revenue>>(data);
            MostrarGraficoTorta(lst);
        }

        private void MostrarGraficoTorta(List<Revenue> lst)
        {
            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
            pieChart2.LegendLocation = LegendLocation.Bottom;
            //List<Revenue> lst = new List<Revenue>();
            DataTable table = new DataTable();

            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-8EMNHC7Q;Initial Catalog=pruebagraficos;Integrated Security=True");

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM anios", cnn);
                cmd.CommandType = CommandType.Text;


                table.Load(cmd.ExecuteReader());
                //mappear los registros como objetos del dominio:

                foreach (DataRow row in table.Rows)
                {
                    //Por cada registro creamos un objeto del dominio
                    Revenue oIngresosTorta = new Revenue();
                    oIngresosTorta.Year = Convert.ToInt32(row["years"].ToString());
                    oIngresosTorta.Value = Convert.ToDouble(row["total"].ToString());

                    lst.Add(oIngresosTorta);
                }

                cnn.Close();
            }
            catch (SqlException)
            {
                lst = null;
            }

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in lst)
            {
                series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<double> { obj.Value }, DataLabels = true, LabelPoint = labelPoint });
            }
            pieChart2.Series = series;
        }


        
    }
}
