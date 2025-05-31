using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class HistorialMedicoForm : Form
    {
        // Ajusta esta cadena de conexión según tu configuración real.
        private readonly string connectionString = "Server=USER-PC\\SQLEXPRESS01;Database=CattleHealthyDB;Trusted_Connection=True;";

        public HistorialMedicoForm()
        {
            InitializeComponent();
        }

        private void HistorialMedicoForm_Load(object sender, EventArgs e)
        {
            CargarBovinosEnCombo();
        }

        private void CargarBovinosEnCombo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id AS IdBovino, Nombre FROM Bovinos ORDER BY Nombre;";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbBovinos.DisplayMember = "Nombre";
                        cbBovinos.ValueMember = "IdBovino";
                        cbBovinos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bovinos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            if (cbBovinos.SelectedValue == null)
            {
                MessageBox.Show("Debes seleccionar un bovino.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBovino = Convert.ToInt32(cbBovinos.SelectedValue);
            CargarHistorialDeBovino(idBovino);
        }

        private void CargarHistorialDeBovino(int idBovino)
        {
            DataTable dtHistorial = new DataTable();
            dtHistorial.Columns.Add("Tipo");       // "Texto" o "Foto"
            dtHistorial.Columns.Add("Fecha");
            dtHistorial.Columns.Add("Detalle");    // Para texto y foto, el texto descriptivo

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1) Obtener diagnósticos por texto
                    string queryTexto = @"
                        SELECT Fecha AS FechaDiagnostico, Diagnostico AS DiagnosticoTexto FROM DiagnosticosTexto WHERE BovinoId = @IdBovino ORDER BY Fecha DESC";
                    using (SqlCommand cmd = new SqlCommand(queryTexto, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdBovino", idBovino);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dtTexto = new DataTable();
                            da.Fill(dtTexto);
                            foreach (DataRow row in dtTexto.Rows)
                            {
                                DataRow newRow = dtHistorial.NewRow();
                                newRow["Tipo"] = "Texto";
                                newRow["Fecha"] = Convert.ToDateTime(row["FechaDiagnostico"]).ToString("yyyy-MM-dd HH:mm");
                                newRow["Detalle"] = row["DiagnosticoTexto"].ToString();
                                dtHistorial.Rows.Add(newRow);
                            }
                        }
                    }

                    // 2) Obtener diagnósticos por foto (solo texto asociado)
                    string queryFoto = @"
                        SELECT Fecha, AnalisisHF, Enfermedades, Causas, Tratamientos
                        FROM DiagnosticosFoto
                        WHERE BovinoId = @IdBovino
                        ORDER BY Fecha DESC";
                    using (SqlCommand cmd = new SqlCommand(queryFoto, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdBovino", idBovino);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dtFoto = new DataTable();
                            da.Fill(dtFoto);
                            foreach (DataRow row in dtFoto.Rows)
                            {
                                DataRow newRow = dtHistorial.NewRow();
                                newRow["Tipo"] = "Foto";
                                newRow["Fecha"] = Convert.ToDateTime(row["Fecha"]).ToString("yyyy-MM-dd HH:mm");
                                // Concatenar los campos de texto
                                string detalleFoto = 
                                    "Análisis HF: " + row["AnalisisHF"].ToString() + Environment.NewLine +
                                    "Enfermedades: " + row["Enfermedades"].ToString() + Environment.NewLine +
                                    "Causas: " + row["Causas"].ToString() + Environment.NewLine +
                                    "Tratamientos: " + row["Tratamientos"].ToString();
                                newRow["Detalle"] = detalleFoto;
                                dtHistorial.Rows.Add(newRow);
                            }
                        }
                    }
                }

                // Cargar el DataTable en el DataGridView
                dgvHistorial.DataSource = dtHistorial;
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
