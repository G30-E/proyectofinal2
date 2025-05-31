
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CattleHealthy_NET9_Final.Data;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class DiagnosticoFotoForm : Form
    {
        // Azure Computer Vision settings
        private const string VisionApiKey = "1weK5om3n18jAcDhHsVIyZU2y4CYVlIKkk4KrEYfg3F85GdNEC3aJQQJ99BEACYeBjFXJ3w3AAAFACOG6qfT";
        private const string VisionEndpoint = "https://cattlehealthy-vision.cognitiveservices.azure.com/computervision/imageanalysis:analyze?api-version=2023-10-01&features=caption&model-version=latest";

        private const string GroqEndpoint = "https://api.groq.com/openai/v1/chat/completions";
        private const string GroqApiKey = "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";
        private const string GroqModel = "mixtral-8x7b-32768";
        private PictureBox pictureBox1;
        private byte[] imagenData;

        // Nested class to bind bovinos cleanly
        private class BovinoItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public override string ToString() => Nombre;
        }

        // UI Controls
        private PictureBox pictureBox;
        private ComboBox cboBovinos;
        private Button btnSubirImagen;
        private Button btnAnalizar;
        private TextBox txtResultado;
        private Button btnExportarPdf;

        public DiagnosticoFotoForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoFotoForm));
            pictureBox = new PictureBox();
            btnSubirImagen = new Button();
            cboBovinos = new ComboBox();
            btnAnalizar = new Button();
            txtResultado = new TextBox();
            btnExportarPdf = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(0, 0);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(75, 23);
            btnSubirImagen.TabIndex = 1;
            btnSubirImagen.Click += btnSubirFoto_Click;
            // 
            // cboBovinos
            // 
            cboBovinos.Location = new Point(0, 0);
            cboBovinos.Name = "cboBovinos";
            cboBovinos.Size = new Size(121, 23);
            cboBovinos.TabIndex = 2;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(0, 0);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(75, 23);
            btnAnalizar.TabIndex = 3;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(0, 0);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Location = new Point(0, 0);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(75, 23);
            btnExportarPdf.TabIndex = 5;
            btnExportarPdf.Click += BtnExportarPdf_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 601);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DiagnosticoFotoForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(pictureBox);
            Controls.Add(btnSubirImagen);
            Controls.Add(cboBovinos);
            Controls.Add(btnAnalizar);
            Controls.Add(txtResultado);
            Controls.Add(btnExportarPdf);
            Controls.Add(pictureBox1);
            Name = "DiagnosticoFotoForm";
            Text = "Diagnóstico por Foto";
            Load += DiagnosticoFotoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DiagnosticoFotoForm_Load(object sender, EventArgs e)
        {
            try
            {
                using var conn = ConexionDB.ObtenerConexion();
                string query = "SELECT Id, Nombre FROM Bovinos";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboBovinos.Items.Add(new BovinoItem
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    });
                }

                if (cboBovinos.Items.Count > 0) cboBovinos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando bovinos: " + ex.Message);
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.png;*.bmp" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var img = System.Drawing.Image.FromFile(ofd.FileName);
                var thumb = new System.Drawing.Bitmap(img, new System.Drawing.Size(512, 512));
                using var ms = new MemoryStream();
                thumb.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imagenData = ms.ToArray();
                pictureBox.Image = thumb;
            }
        }

        private async void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (imagenData == null)
            {
                MessageBox.Show("Por favor, sube una foto primero.");
                return;
            }

            if (!(cboBovinos.SelectedItem is BovinoItem selectedBovino))
            {
                MessageBox.Show("Selecciona un bovino.");
                return;
            }

            int bovinoId = selectedBovino.Id;
            txtResultado.Text = "Analizando imagen...";
try
{
    // 1. Obtener caption con Azure Vision
    string caption = string.Empty;
    using (var client = new HttpClient())
    {
        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", VisionApiKey);
        using var content = new ByteArrayContent(imagenData);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        var response = await client.PostAsync(VisionEndpoint, content);
        var responseBody = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"Azure Vision error {response.StatusCode}: {responseBody}");

        var root = JObject.Parse(responseBody);
        if (root["captionResult"]? ["text"] != null)
            caption = root["captionResult"]["text"].ToString();
        else if (root["description"]? ["captions"]? [0]? ["text"] != null)
            caption = root["description"]["captions"][0]["text"].ToString();

        if (string.IsNullOrWhiteSpace(caption))
            throw new Exception("El servicio no proporcionó una descripción de la imagen.");
    }

    // 2. Enviar caption a Groq
    string groqResponse;
    using (var client = new HttpClient())
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GroqApiKey);
        var payload = new
        {
            model = "llama3-70b-8192",
            messages = new[]
            {
                new { role = "system", content = "Eres un asistente que responde en español." },
                new { role = "user", content = $"Detalle de posibles enfermedades, sus causas, tratamiento y prevención para: {caption}" }
            }
        };
        var jsonPayload = JsonConvert.SerializeObject(payload);
        using var content2 = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
        var response2 = await client.PostAsync(GroqEndpoint, content2);
        var responseBody2 = await response2.Content.ReadAsStringAsync();
        if (!response2.IsSuccessStatusCode)
            throw new Exception($"Groq error {response2.StatusCode}: {responseBody2}");

        var rootG = JObject.Parse(responseBody2);
        groqResponse = rootG["choices"]?[0]? ["message"]? ["content"]?.ToString() ?? "(Groq no retornó contenido)";
    }

    // 3. Mostrar y guardar
    txtResultado.Text = groqResponse;
    await ConexionDB.SaveDiagnosticoFotoAsync(bovinoId, imagenData, caption, groqResponse, "", "");
    MessageBox.Show("Diagnóstico guardado exitosamente.");
}
catch (Exception ex)
{
    MessageBox.Show("Error: " + ex.Message);
}
        }
        private void BtnExportarPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("No hay diagnóstico para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = "diagnostico_foto.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph(txtResultado.Text, FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                        doc.Close();
                        MessageBox.Show("PDF exportado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}