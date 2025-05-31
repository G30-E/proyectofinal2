using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Data;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class RegistrarBobinoForm : Form
    {
        public RegistrarBobinoForm()
        {
            InitializeComponent();
        }

        private void btnGuardarBobino_Click(object sender, EventArgs e)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                var cmd = new SqlCommand("INSERT INTO Bovinos (Nombre, Edad, Peso) VALUES (@n,@e,@p)", conn);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                cmd.Parameters.AddWithValue("@e", int.Parse(txtEdad.Text));
                cmd.Parameters.AddWithValue("@p", double.Parse(txtPeso.Text));
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Bobino registrado");
        }
    }
}
