using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblRole;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblRole = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
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
            txtUsuario.Location = new System.Drawing.Point(50, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new System.Drawing.Size(236, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(50, 87);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new System.Drawing.Size(236, 23);
            txtContrasena.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Image = (System.Drawing.Image)resources.GetObject("btnIngresar.Image");
            btnIngresar.Location = new System.Drawing.Point(82, 148);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(164, 58);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(337, 231);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            ClientSize = new System.Drawing.Size(337, 233);
            Controls.Add(lblRole);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
