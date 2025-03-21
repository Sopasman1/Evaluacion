using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Grafica : Form
    {
        private string apiKey = "af8edec1918412ed12cb4d20ac362cf73b3673635fd2d2a61beae9e1f068acd7";
        public Grafica()
        {
            InitializeComponent();
        }

        private async void btnconsulta2_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEnddate.Value;

            
            if (startDate > endDate)
            {
                MessageBox.Show("La fecha de inicio debe ser menor o igual a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}?token={apiKey}";
                var data = await FetchDataFromApi(url);

               
                DisplayGraph(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<JObject> FetchDataFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JObject.Parse(responseBody);
            }
        }

        private void DisplayGraph(JObject data)
        {
            
            formsPlot1.Reset();

          
            var observations = data["bmx"]["series"][0]["datos"];
            List<double> values = new List<double>();

            foreach (var obs in observations)
            {
                values.Add(double.Parse(obs["dato"].ToString()));
            }

            
            if (values.Count > 0)
            {
                
                double[] xValues = Enumerable.Range(0, values.Count).Select(i => (double)i).ToArray();
                double[] yValues = values.ToArray();

               
                var scatter = formsPlot1.Plot.Add.Scatter(xValues, yValues);
                scatter.Label = "Tipo de Cambio";

                
                formsPlot1.Plot.Title("Tipo de Cambio Peso a Dólar");
                formsPlot1.Plot.XLabel("Índice");
                formsPlot1.Plot.YLabel("Valor");

                
                formsPlot1.Refresh();
            }
            else
            {
                MessageBox.Show("No hay datos disponibles para el rango de fechas seleccionado.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
