using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Data;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class LoginForm : Form
    {
        private readonly string role;
        private StartForm startFormRef;

        public LoginForm()
            : this("Usuario", null)
        {
        }

        // Sobrecarga para inicializar sólo con rol
        public LoginForm(string role)
            : this(role, null)
        {
        }

        public LoginForm(string role, StartForm inicio)
        {
            InitializeComponent();
            this.role = role;
            this.startFormRef = inicio;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContrasena.Text;

            using(var conn = ConexionDB.ObtenerConexion())
            {
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario=@u AND Contrasena=@p AND Rol=@r", conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@r", role);
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    MenuForm menu = new MenuForm(role);
                    menu.Show();
                    this.Hide();
                    foreach(Form frm in Application.OpenForms)
                    {
                        if(frm is MainForm)
                        {
                            frm.Hide();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}