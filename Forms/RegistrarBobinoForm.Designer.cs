using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class RegistrarBobinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblPeso;
        private TextBox txtPeso;
        private Button btnGuardarBobino;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarBobinoForm));
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            btnGuardarBobino = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(54, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(78, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "ID o Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(149, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(219, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new System.Drawing.Point(37, 65);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(95, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad del bovino:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new System.Drawing.Point(149, 62);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new System.Drawing.Size(219, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new System.Drawing.Point(64, 114);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new System.Drawing.Size(68, 15);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "Peso en Kg:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new System.Drawing.Point(149, 111);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new System.Drawing.Size(219, 23);
            txtPeso.TabIndex = 5;
            // 
            // btnGuardarBobino
            // 
            btnGuardarBobino.Image = (System.Drawing.Image)resources.GetObject("btnGuardarBobino.Image");
            btnGuardarBobino.Location = new System.Drawing.Point(135, 157);
            btnGuardarBobino.Name = "btnGuardarBobino";
            btnGuardarBobino.Size = new System.Drawing.Size(138, 64);
            btnGuardarBobino.TabIndex = 6;
            btnGuardarBobino.Text = "Guardar Bobino";
            btnGuardarBobino.Click += btnGuardarBobino_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(411, 247);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // RegistrarBobinoForm
            // 
            ClientSize = new System.Drawing.Size(410, 240);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblPeso);
            Controls.Add(txtPeso);
            Controls.Add(btnGuardarBobino);
            Controls.Add(pictureBox1);
            Name = "RegistrarBobinoForm";
            Text = "Registrar Bobino";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
