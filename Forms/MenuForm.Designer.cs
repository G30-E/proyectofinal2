using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnRegistrarBobino;
        private Button btnDiagnosticoTexto;
        private System.Windows.Forms.Button btnDiagnosticoFoto;
        private System.Windows.Forms.Button btnHistorialMedico;

    private Button btnCerrarSesion;
        private Button btnEliminarBobino;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            lblWelcome = new Label();
            btnRegistrarBobino = new Button();
            btnDiagnosticoTexto = new Button();
            btnCerrarSesion = new Button();
            btnDiagnosticoFoto = new Button();
            btnHistorialMedico = new Button();
            btnEliminarBobino = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(0, 15);
            lblWelcome.TabIndex = 0;
            // 
            // btnRegistrarBobino
            // 
            btnRegistrarBobino.Image = (System.Drawing.Image)resources.GetObject("btnRegistrarBobino.Image");
            btnRegistrarBobino.Location = new System.Drawing.Point(54, 179);
            btnRegistrarBobino.Name = "btnRegistrarBobino";
            btnRegistrarBobino.Size = new System.Drawing.Size(208, 77);
            btnRegistrarBobino.TabIndex = 1;
            btnRegistrarBobino.Text = "Registrar Bobino";
            btnRegistrarBobino.Click += btnRegistrarBobino_Click;
            // 
            // btnDiagnosticoTexto
            // 
            btnDiagnosticoTexto.Image = (System.Drawing.Image)resources.GetObject("btnDiagnosticoTexto.Image");
            btnDiagnosticoTexto.Location = new System.Drawing.Point(54, 78);
            btnDiagnosticoTexto.Name = "btnDiagnosticoTexto";
            btnDiagnosticoTexto.Size = new System.Drawing.Size(208, 77);
            btnDiagnosticoTexto.TabIndex = 2;
            btnDiagnosticoTexto.Text = "Diagnóstico por Texto";
            btnDiagnosticoTexto.Click += btnDiagnosticoTexto_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Image = (System.Drawing.Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.Location = new System.Drawing.Point(359, 281);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new System.Drawing.Size(208, 77);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnDiagnosticoFoto
            // 
            btnDiagnosticoFoto.Image = (System.Drawing.Image)resources.GetObject("btnDiagnosticoFoto.Image");
            btnDiagnosticoFoto.Location = new System.Drawing.Point(359, 179);
            btnDiagnosticoFoto.Name = "btnDiagnosticoFoto";
            btnDiagnosticoFoto.Size = new System.Drawing.Size(208, 77);
            btnDiagnosticoFoto.TabIndex = 3;
            btnDiagnosticoFoto.Text = "Diagnóstico Foto";
            btnDiagnosticoFoto.UseVisualStyleBackColor = true;
            btnDiagnosticoFoto.Click += btnDiagnosticoFoto_Click;
            // 
            // btnHistorialMedico
            // 
            btnHistorialMedico.Image = (System.Drawing.Image)resources.GetObject("btnHistorialMedico.Image");
            btnHistorialMedico.Location = new System.Drawing.Point(54, 281);
            btnHistorialMedico.Name = "btnHistorialMedico";
            btnHistorialMedico.Size = new System.Drawing.Size(208, 77);
            btnHistorialMedico.TabIndex = 4;
            btnHistorialMedico.Text = "Historial Médico";
            btnHistorialMedico.UseVisualStyleBackColor = true;
            btnHistorialMedico.Click += btnHistorialMedico_Click;
            // 
            // btnEliminarBobino
            // 
            btnEliminarBobino.Image = (System.Drawing.Image)resources.GetObject("btnEliminarBobino.Image");
            btnEliminarBobino.Location = new System.Drawing.Point(359, 78);
            btnEliminarBobino.Name = "btnEliminarBobino";
            btnEliminarBobino.Size = new System.Drawing.Size(208, 77);
            btnEliminarBobino.TabIndex = 5;
            btnEliminarBobino.Text = "Eliminar Bovino";
            btnEliminarBobino.UseVisualStyleBackColor = true;
            btnEliminarBobino.Click += btnEliminarBobino_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(623, 383);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            ClientSize = new System.Drawing.Size(621, 380);
            Controls.Add(lblWelcome);
            Controls.Add(btnRegistrarBobino);
            Controls.Add(btnDiagnosticoTexto);
            Controls.Add(btnDiagnosticoFoto);
            Controls.Add(btnHistorialMedico);
            Controls.Add(btnEliminarBobino);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox1);
            Name = "MenuForm";
            Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}