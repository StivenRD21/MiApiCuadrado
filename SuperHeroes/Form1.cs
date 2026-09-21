using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHeroes
{
    public partial class Form1 : Form
    {
  
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevoHeroe = new SuperHeroe
            {
                nombreHeroe = txtNombreHeroe.Text,
                nombreReal = txtNombreReal.Text,
                poder = txtPoder.Text
            };

            string json = JsonSerializer.Serialize(nuevoHeroe);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                string apiUrl = "https://superheroesdemiapi-b3a5hxfub3h4argw.centralus-01.azurewebsites.net/api/superheroes";

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("¡Héroe registrado exitosamente en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombreHeroe.Clear();
                    txtNombreReal.Clear();
                    txtPoder.Clear();
                    await CargarHeroesAsync();
                }
                else
                {
                    string errorDetalle = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error de la API: {response.StatusCode}\n\nDetalle:\n{errorDetalle}", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CargarHeroesAsync()
        {
            try
            {
                string apiUrl = "https://superheroesdemiapi-b3a5hxfub3h4argw.centralus-01.azurewebsites.net/api/superheroes";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var opciones = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var heroes = System.Text.Json.JsonSerializer.Deserialize<List<SuperHeroe>>(json, opciones);

                    dgvHeroes.DataSource = heroes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarHeroesAsync();
        }
    }
}