using System;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            using(var login = new LoginForm())
            {
                login.ShowDialog();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using(var form = new RegistroUsuarioForm())
            {
                form.ShowDialog();
            }
        }
    }
}
