using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CattleHealthy_NET9_Final.Data;
// Para exportar a PDF, instala la librería iTextSharp (NuGet: iTextSharp-LGPL)
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class DiagnosticoTextoForm : Form
    {
        private const string GroqEndpoint = "https://api.groq.com/openai/v1/chat/completions";
        private const string GroqApiKey = "   ";

        private Button btnExportarPdf;

        public DiagnosticoTextoForm()
        {
            InitializeComponent();
            LoadBovinos();

            // Configurar botón Exportar a PDF
            btnExportarPdf = new Button
            {
                Text = "Exportar a PDF",
                Location = new Point(txtResultado.Location.X + txtResultado.Width + 10, txtResultado.Location.Y),
                Size = new Size(100, 23)
            };
            btnExportarPdf.Click += BtnExportarPdf_Click;
            this.Controls.Add(btnExportarPdf);
        }

        private async void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            var sintomas = txtSintomas.Text.Trim();
            if (string.IsNullOrEmpty(sintomas))
            {
                MessageBox.Show("Ingrese síntomas");
                return;
            }

            try
            {
                // Llamada a Groq
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {GroqApiKey}");
                var body = new
                {
                    model = "llama3-70b-8192",
                    messages = new[]
                    {
                        new { role = "user", content = sintomas }
                    }
                };
                var jsonBody = JsonConvert.SerializeObject(body);
                var response = await client.PostAsync(GroqEndpoint,
                    new StringContent(jsonBody, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();
                var resultJson = await response.Content.ReadAsStringAsync();
                dynamic resultObj = JsonConvert.DeserializeObject(resultJson);
                string resultado = resultObj.choices[0].message.content;
                txtResultado.Text = resultado;

                // Guardar diagnóstico en BD
                int bovinoId = (int)cbBovinos.SelectedValue;
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    var cmd = new SqlCommand(@"
INSERT INTO DiagnosticosTexto (BovinoId, Fecha, Diagnostico)
VALUES (@bovinoId, GETDATE(), @diag)", conn);
                    cmd.Parameters.AddWithValue("@bovinoId", bovinoId);
                    cmd.Parameters.AddWithValue("@diag", resultado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al diagnosticar: " + ex.Message);
            }
        }

        private void BtnExportarPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("No hay diagnóstico para exportar");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = "diagnostico.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph($"Diagnóstico del bovino: {cbBovinos.Text}"));
                        doc.Add(new Paragraph($"Fecha: {DateTime.Now}"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(txtResultado.Text));
                        doc.Close();
                        MessageBox.Show("PDF exportado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar PDF: " + ex.Message);
                    }
                }
            }
        }

        private async void LoadBovinos()
        {
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    var cmd = new SqlCommand("SELECT Id, Nombre FROM dbo.bovinos;", conn);
                    using var reader = await cmd.ExecuteReaderAsync();
                    var table = new DataTable();
                    table.Load(reader);

                    cbBovinos.DataSource = table;
                    cbBovinos.DisplayMember = "Nombre";
                    cbBovinos.ValueMember = "Id";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL al cargar bovinos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bovinos: " + ex.Message);
            }
        }

        private void DiagnosticoTextoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
