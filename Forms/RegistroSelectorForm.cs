using System;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class RegistroSelectorForm : Form
    {
        public RegistroSelectorForm()
        {
            InitializeComponent();
        }

        private void btnRegistroAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            using(var form = new RegistroUsuarioForm("Administrador"))
                form.ShowDialog();
            Show();
        }

        private void btnRegistroVet_Click(object sender, EventArgs e)
        {
            Hide();
            using(var form = new RegistroUsuarioForm("Veterinario"))
                form.ShowDialog();
            Show();
        }
    }
}
