using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class RegistroSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRegistroAdmin;
        private Button btnRegistroVet;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRegistroAdmin = new Button();
            this.btnRegistroVet = new Button();
            this.SuspendLayout();
            // btnRegistroAdmin
            this.btnRegistroAdmin.Location = new System.Drawing.Point(40, 30);
            this.btnRegistroAdmin.Name = "btnRegistroAdmin";
            this.btnRegistroAdmin.Size = new System.Drawing.Size(220, 30);
            this.btnRegistroAdmin.Text = "Registrar Administrador";
            this.btnRegistroAdmin.Click += new System.EventHandler(this.btnRegistroAdmin_Click);
            // btnRegistroVet
            this.btnRegistroVet.Location = new System.Drawing.Point(40, 80);
            this.btnRegistroVet.Name = "btnRegistroVet";
            this.btnRegistroVet.Size = new System.Drawing.Size(220, 30);
            this.btnRegistroVet.Text = "Registrar Veterinario";
            this.btnRegistroVet.Click += new System.EventHandler(this.btnRegistroVet_Click);
            // RegistroSelectorForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnRegistroAdmin);
            this.Controls.Add(this.btnRegistroVet);
            this.Name = "RegistroSelectorForm";
            this.Text = "Seleccionar Registro";
            this.ResumeLayout(false);
        }
    }
}
