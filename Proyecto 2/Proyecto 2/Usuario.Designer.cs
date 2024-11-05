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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            label2 = new Label();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            Ingresar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 42);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 11;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 10;
            label1.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(262, 79);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(220, 35);
            txtContraseña.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(12, 79);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '*';
            txtUsuario.Size = new Size(217, 35);
            txtUsuario.TabIndex = 8;
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(145, 131);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(193, 41);
            Ingresar.TabIndex = 12;
            Ingresar.Text = "Iniciar Seccion";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(262, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 71, 230);
            ClientSize = new Size(499, 184);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            ForeColor = Color.Black;
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button Ingresar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}