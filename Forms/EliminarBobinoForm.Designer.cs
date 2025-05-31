using System;
using System.Windows.Forms;

namespace CattleHealthy_NET9_Final.Forms
{
    partial class EliminarBobinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblSeleccione;
        private ComboBox cmbBovinos;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarBobinoForm));
            lblSeleccione = new Label();
            cmbBovinos = new ComboBox();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Location = new System.Drawing.Point(110, 36);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new System.Drawing.Size(103, 15);
            lblSeleccione.TabIndex = 0;
            lblSeleccione.Text = "Seleccione Bovino";
            // 
            // cmbBovinos
            // 
            cmbBovinos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBovinos.FormattingEnabled = true;
            cmbBovinos.Location = new System.Drawing.Point(61, 62);
            cmbBovinos.Name = "cmbBovinos";
            cmbBovinos.Size = new System.Drawing.Size(200, 23);
            cmbBovinos.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.Location = new System.Drawing.Point(90, 143);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(138, 53);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(325, 231);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // EliminarBobinoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(325, 231);
            Controls.Add(lblSeleccione);
            Controls.Add(cmbBovinos);
            Controls.Add(btnEliminar);
            Controls.Add(pictureBox1);
            Name = "EliminarBobinoForm";
            Text = "Eliminar Bovino";
            Load += EliminarBobinoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
