using System;
using System.Windows.Forms;
namespace CattleHealthy_NET9_Final.Forms
{
    partial class DiagnosticoTextoForm
    {
        private System.Windows.Forms.Label lblBovino;
        private System.Windows.Forms.ComboBox cbBovinos;
        private System.ComponentModel.IContainer components = null;
        private Label lblSintomas;
        private TextBox txtSintomas;
        private Button btnDiagnosticar;
        private TextBox txtResultado;

        protected override void Dispose(bool disposing)
        {
            if(disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoTextoForm));
            lblSintomas = new Label();
            txtSintomas = new TextBox();
            btnDiagnosticar = new Button();
            txtResultado = new TextBox();
            lblBovino = new Label();
            cbBovinos = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Location = new System.Drawing.Point(29, 60);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new System.Drawing.Size(59, 15);
            lblSintomas.TabIndex = 0;
            lblSintomas.Text = "Síntomas:";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new System.Drawing.Point(29, 80);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new System.Drawing.Size(521, 80);
            txtSintomas.TabIndex = 1;
            // 
            // btnDiagnosticar
            // 
            btnDiagnosticar.Image = (System.Drawing.Image)resources.GetObject("btnDiagnosticar.Image");
            btnDiagnosticar.Location = new System.Drawing.Point(202, 176);
            btnDiagnosticar.Name = "btnDiagnosticar";
            btnDiagnosticar.Size = new System.Drawing.Size(147, 56);
            btnDiagnosticar.TabIndex = 4;
            btnDiagnosticar.Text = "Diagnosticar";
            btnDiagnosticar.Click += btnDiagnosticar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new System.Drawing.Point(29, 271);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new System.Drawing.Size(409, 179);
            txtResultado.TabIndex = 5;
            // 
            // lblBovino
            // 
            lblBovino.AutoSize = true;
            lblBovino.Location = new System.Drawing.Point(29, 26);
            lblBovino.Name = "lblBovino";
            lblBovino.Size = new System.Drawing.Size(47, 15);
            lblBovino.TabIndex = 2;
            lblBovino.Text = "Bovino:";
            // 
            // cbBovinos
            // 
            cbBovinos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBovinos.FormattingEnabled = true;
            cbBovinos.Location = new System.Drawing.Point(83, 23);
            cbBovinos.Name = "cbBovinos";
            cbBovinos.Size = new System.Drawing.Size(223, 23);
            cbBovinos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(581, 464);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DiagnosticoTextoForm
            // 
            ClientSize = new System.Drawing.Size(578, 462);
            Controls.Add(lblSintomas);
            Controls.Add(txtSintomas);
            Controls.Add(lblBovino);
            Controls.Add(cbBovinos);
            Controls.Add(btnDiagnosticar);
            Controls.Add(txtResultado);
            Controls.Add(pictureBox1);
            Name = "DiagnosticoTextoForm";
            Text = "Diagnóstico por Texto";
            Load += DiagnosticoTextoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
