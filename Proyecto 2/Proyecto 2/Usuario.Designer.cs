namespace Proyecto_2
{
    partial class Usuario
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            Ingresar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 11;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 10;
            label1.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(262, 43);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(220, 35);
            txtContraseña.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(12, 43);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 35);
            txtUsuario.TabIndex = 8;
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(148, 95);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(193, 41);
            Ingresar.TabIndex = 12;
            Ingresar.Text = "Iniciar Seccion";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 71, 230);
            ClientSize = new Size(499, 157);
            Controls.Add(Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            ForeColor = Color.Black;
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button Ingresar;
    }
}