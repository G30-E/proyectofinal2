using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Data;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class EliminarBobinoForm : Form
    {
        public EliminarBobinoForm()
        {
            InitializeComponent();
        }

        private void EliminarBobinoForm_Load(object sender, EventArgs e)
        {
            LoadBovinos();
        }

        private void LoadBovinos()
        {
            cmbBovinos.Items.Clear();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                var cmd = new SqlCommand("SELECT Id, Nombre FROM Bovinos", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbBovinos.Items.Add(new ComboboxItem
                        {
                            Text = reader.GetString(1),
                            Value = reader.GetInt32(0)
                        });
                    }
                }
            }
            if (cmbBovinos.Items.Count > 0)
                cmbBovinos.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbBovinos.SelectedItem is ComboboxItem item)
            {
                int id = item.Value;
                var confirm = MessageBox.Show($"¿Está seguro de eliminar el bovino '{item.Text}'?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var conn = ConexionDB.ObtenerConexion())
                    {
                        using (var tran = conn.BeginTransaction())
                        {
                            var cmd1 = new SqlCommand("DELETE FROM DiagnosticosTexto WHERE BovinoId = @id", conn, tran);
                            cmd1.Parameters.AddWithValue("@id", id);
                            cmd1.ExecuteNonQuery();
                            var cmd = new SqlCommand("DELETE FROM Bovinos WHERE Id = @id", conn, tran);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                    }
                    MessageBox.Show("Bovino eliminado");
                    LoadBovinos();
                }
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}