namespace CattleHealthy_NET9_Final.Forms
{
    partial class HistorialMedicoForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary> 
        /// Required method for Designer support – do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialMedicoForm));
            cbBovinos = new System.Windows.Forms.ComboBox();
            lblSeleccionBovino = new System.Windows.Forms.Label();
            btnMostrarHistorial = new System.Windows.Forms.Button();
            dgvHistorial = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbBovinos
            // 
            cbBovinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbBovinos.FormattingEnabled = true;
            cbBovinos.Location = new System.Drawing.Point(140, 17);
            cbBovinos.Name = "cbBovinos";
            cbBovinos.Size = new System.Drawing.Size(200, 23);
            cbBovinos.TabIndex = 1;
            // 
            // lblSeleccionBovino
            // 
            lblSeleccionBovino.AutoSize = true;
            lblSeleccionBovino.Location = new System.Drawing.Point(20, 20);
            lblSeleccionBovino.Name = "lblSeleccionBovino";
            lblSeleccionBovino.Size = new System.Drawing.Size(106, 15);
            lblSeleccionBovino.TabIndex = 0;
            lblSeleccionBovino.Text = "Selecciona Bovino:";
            // 
            // btnMostrarHistorial
            // 
            btnMostrarHistorial.Image = (System.Drawing.Image)resources.GetObject("btnMostrarHistorial.Image");
            btnMostrarHistorial.Location = new System.Drawing.Point(406, 12);
            btnMostrarHistorial.Name = "btnMostrarHistorial";
            btnMostrarHistorial.Size = new System.Drawing.Size(160, 38);
            btnMostrarHistorial.TabIndex = 2;
            btnMostrarHistorial.Text = "Mostrar Historial";
            btnMostrarHistorial.UseVisualStyleBackColor = true;
            btnMostrarHistorial.Click += btnMostrarHistorial_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new System.Drawing.Point(20, 60);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.Size = new System.Drawing.Size(600, 300);
            dgvHistorial.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(651, 384);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HistorialMedicoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 380);
            Controls.Add(dgvHistorial);
            Controls.Add(btnMostrarHistorial);
            Controls.Add(cbBovinos);
            Controls.Add(lblSeleccionBovino);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HistorialMedicoForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Historial Médico de Bovino";
            Load += HistorialMedicoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionBovino;
        private System.Windows.Forms.ComboBox cbBovinos;
        private System.Windows.Forms.Button btnMostrarHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}