using System;
using System.Windows.Forms;
using CattleHealthy_NET9_Final.Forms;
using CattleHealthy_NET9_Final.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    public partial class MenuForm : Form
    {
        private readonly string role;
        public MenuForm(string role)
        {
            this.role = role;
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido, {role}";
        }

        private void btnRegistrarBobino_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarBobinoForm())
            {
                form.ShowDialog();
            }
        }

        private void btnDiagnosticoTexto_Click(object sender, EventArgs e)
        {
            using (var form = new DiagnosticoTextoForm())
            {
                form.ShowDialog();
            }
        }

        private void btnDiagnosticoFoto_Click(object sender, EventArgs e)
        {
            using (var form = new DiagnosticoFotoForm())
            {
                form.ShowDialog();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnHistorialMedico_Click(object sender, EventArgs e)
        {
            using (var form = new HistorialMedicoForm())
            {
                form.ShowDialog();
            }
        }
        private void btnEliminarBobino_Click(object sender, EventArgs e)
        {
            using (var form = new EliminarBobinoForm())
            {
                form.ShowDialog();
            }
        }

    }
}