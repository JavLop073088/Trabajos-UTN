using BancoBack.Dominio;
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
        
        private async void FrmGrafico_Load(object sender, EventArgs e)
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
            await CargarTortaAsync();
        }

        private async void btnConsultar_Click_1(object sender, EventArgs e)
        {
            await CargarCartesiano();
        }

        //-------------------------------------------------------------------------------------------
        //Métodos HttpClient:
        private async Task CargarTortaAsync()
        {
            string url = "https://localhost:44317/api/Banco/cuentasTorta";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Revenue> lst = JsonConvert.DeserializeObject<List<Revenue>>(data);
            MostrarGraficoTorta(lst);
        }

        private async Task CargarCartesiano()
        {
            string url = "https://localhost:44317/api/Banco/cartesiano";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Revenue> lst = JsonConvert.DeserializeObject<List<Revenue>>(data);
            MostrarGraficoCartesiano(lst);
        }
        //-------------------------------------------------------------------------------------------
        //Métodos Auxiliares:
        private void MostrarGraficoTorta(List<Revenue> lst)
        {
            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
            pieChart2.LegendLocation = LegendLocation.Bottom;
            

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in lst)
            {
                series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<double> { obj.Value }, DataLabels = true, LabelPoint = labelPoint });
            }
            pieChart2.Series = series;
        }

        private void MostrarGraficoCartesiano(List<Revenue> lst)
        {
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
    }
}
