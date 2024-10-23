namespace Proyecto_2
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            label2 = new Label();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Registro = new Button();
            RpLector = new RadioButton();
            RpBiblio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 214);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(231, 23);
            txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 157);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(231, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(231, 90);
            label6.TabIndex = 9;
            label6.Text = "Libreria\r\nSan Pedro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(231, 90);
            label3.TabIndex = 10;
            label3.Text = "Libreria\r\nSan Pedro";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(291, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            Registro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registro.Location = new Point(393, 243);
            Registro.Name = "Registro";
            Registro.Size = new Size(149, 49);
            Registro.TabIndex = 12;
            Registro.Text = "Registrar";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
            // 
            // RpLector
            // 
            RpLector.AutoSize = true;
            RpLector.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RpLector.Location = new Point(12, 253);
            RpLector.Name = "RpLector";
            RpLector.Size = new Size(83, 29);
            RpLector.TabIndex = 13;
            RpLector.TabStop = true;
            RpLector.Text = "Lector";
            RpLector.UseVisualStyleBackColor = true;
            // 
            // RpBiblio
            // 
            RpBiblio.AutoSize = true;
            RpBiblio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RpBiblio.Location = new Point(106, 253);
            RpBiblio.Name = "RpBiblio";
            RpBiblio.Size = new Size(137, 29);
            RpBiblio.TabIndex = 14;
            RpBiblio.TabStop = true;
            RpBiblio.Text = "Bibliotecario";
            RpBiblio.UseVisualStyleBackColor = true;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 191, 230);
            ClientSize = new Size(576, 304);
            Controls.Add(RpBiblio);
            Controls.Add(RpLector);
            Controls.Add(Registro);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "RegistroUsuario";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label6;
        private Label label3;
        private PictureBox pictureBox1;
        private Button Registro;
        private RadioButton RpLector;
        private RadioButton RpBiblio;
    }
}