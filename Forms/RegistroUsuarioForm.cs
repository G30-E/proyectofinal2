using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Data;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class RegistroUsuarioForm : Form
    {
        private readonly string role;

        public RegistroUsuarioForm()
            : this("Usuario")
        {
        }

        public RegistroUsuarioForm(string role)
        {
            this.role = role;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                var cmd = new SqlCommand("INSERT INTO Usuarios (Usuario, Contrasena, Rol) VALUES (@u,@p,@r)", conn);
                cmd.Parameters.AddWithValue("@u", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@p", txtContrasena.Text);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show($"Usuario {role} registrado");
        }
    }
}
