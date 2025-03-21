using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Evaluacion
{
    public partial class Formdatagred : Form
    {
        private string apiKey = "af8edec1918412ed12cb4d20ac362cf73b3673635fd2d2a61beae9e1f068acd7";
        public Formdatagred()
        {
            InitializeComponent();
        }

        private async void btnconsulta_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("The start date must be less than or equal to the end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}?token={apiKey}";
                var data = await FetchDataFromApi(url);

               
                DisplayResults(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error querying the API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DisplayResults(JObject data)
        {
            
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();

            
            dgvResults.Columns.Add("date", "Date");
            dgvResults.Columns.Add("value", "Exchange Rate");

           
            var observations = data["bmx"]["series"][0]["datos"];
            foreach (var obs in observations)
            {
                string date = obs["fecha"].ToString();
                string value = obs["dato"].ToString();

                
                dgvResults.Rows.Add(date, value);
            }
        }
    }
}
