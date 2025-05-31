namespace CattleHealthy_NET9_Final.Forms
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;

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
            btnIniciarSesion = new System.Windows.Forms.Button();
            btnRegistrarse = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new System.Drawing.Point(66, 47);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new System.Drawing.Size(131, 38);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new System.Drawing.Point(66, 103);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new System.Drawing.Size(131, 38);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(510, 239);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSesion);
            Name = "StartForm";
            Text = "Bienvenido";
            ResumeLayout(false);
        }
    }
}
