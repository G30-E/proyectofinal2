using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class LoginSelectorForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAdminLogin;
        private Button btnVetLogin;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdminLogin = new Button();
            this.btnVetLogin = new Button();
            this.SuspendLayout();
            // btnAdminLogin
            this.btnAdminLogin.Location = new System.Drawing.Point(40, 30);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(220, 30);
            this.btnAdminLogin.Text = "Iniciar como Administrador";
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // btnVetLogin
            this.btnVetLogin.Location = new System.Drawing.Point(40, 80);
            this.btnVetLogin.Name = "btnVetLogin";
            this.btnVetLogin.Size = new System.Drawing.Size(220, 30);
            this.btnVetLogin.Text = "Iniciar como Veterinario";
            this.btnVetLogin.Click += new System.EventHandler(this.btnVetLogin_Click);
            // LoginSelectorForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnVetLogin);
            this.Name = "LoginSelectorForm";
            this.Text = "Seleccionar Inicio";
            this.ResumeLayout(false);
        }
    }
}
