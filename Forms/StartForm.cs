using System;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selector = new LoginSelectorForm())
            {
                selector.ShowDialog();
            }
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selector = new RegistroSelectorForm())
            {
                selector.ShowDialog();
            }
            this.Close();
        }
    }
}
