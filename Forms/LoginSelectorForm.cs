using System;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class LoginSelectorForm : Form
    {
        public LoginSelectorForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Hide();
            using(var login = new LoginForm("Administrador"))
                login.ShowDialog();
            Show();
        }

        private void btnVetLogin_Click(object sender, EventArgs e)
        {
            Hide();
            using(var login = new LoginForm("Veterinario"))
                login.ShowDialog();
            Show();
        }
    }
}
