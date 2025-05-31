using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class RegistroUsuarioForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRole;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarioForm));
            lblRole = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(30, 20);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(0, 15);
            lblRole.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(93, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new System.Drawing.Size(215, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(93, 92);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new System.Drawing.Size(215, 23);
            txtContrasena.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(115, 146);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(161, 68);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(403, 234);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RegistroUsuarioForm
            // 
            ClientSize = new System.Drawing.Size(401, 235);
            Controls.Add(lblRole);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox1);
            Name = "RegistroUsuarioForm";
            Text = "Registro Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
