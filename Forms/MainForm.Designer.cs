using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;

        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Image = (System.Drawing.Image)resources.GetObject("btnIniciarSesion.Image");
            btnIniciarSesion.Location = new System.Drawing.Point(309, 36);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new System.Drawing.Size(200, 79);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Image = (System.Drawing.Image)resources.GetObject("btnRegistrarse.Image");
            btnRegistrarse.Location = new System.Drawing.Point(309, 157);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new System.Drawing.Size(200, 79);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(0, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(559, 277);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(556, 270);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnRegistrarse);
            Controls.Add(pictureBox2);
            Name = "MainForm";
            Text = "CattleHealthy";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox2;
    }
}
