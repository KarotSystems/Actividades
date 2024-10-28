namespace Proyecto_2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buscar = new Label();
            gestionuser = new Label();
            libreria = new Label();
            Modulopretamos = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 5);
            label1.Name = "label1";
            label1.Size = new Size(263, 34);
            label1.TabIndex = 0;
            label1.Text = "Menú Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 134);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 90);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // buscar
            // 
            buscar.AutoSize = true;
            buscar.BackColor = Color.Transparent;
            buscar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            buscar.Location = new Point(18, 90);
            buscar.Name = "buscar";
            buscar.Size = new Size(170, 30);
            buscar.TabIndex = 3;
            buscar.Text = "2) Buscar Libro";
            buscar.Click += buscar_Click;
            // 
            // gestionuser
            // 
            gestionuser.AutoSize = true;
            gestionuser.BackColor = Color.Transparent;
            gestionuser.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            gestionuser.Location = new Point(18, 134);
            gestionuser.Name = "gestionuser";
            gestionuser.Size = new Size(244, 30);
            gestionuser.TabIndex = 4;
            gestionuser.Text = "3) Gestion de Usuarios";
            gestionuser.Click += gestionuser_Click;
            // 
            // libreria
            // 
            libreria.AutoSize = true;
            libreria.BackColor = Color.Transparent;
            libreria.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libreria.ForeColor = SystemColors.ControlText;
            libreria.Location = new Point(18, 42);
            libreria.Name = "libreria";
            libreria.Size = new Size(123, 30);
            libreria.TabIndex = 5;
            libreria.Text = "1) Libreria";
            libreria.Click += libreria_Click;
            // 
            // Modulopretamos
            // 
            Modulopretamos.AutoSize = true;
            Modulopretamos.BackColor = Color.Transparent;
            Modulopretamos.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Modulopretamos.Location = new Point(18, 179);
            Modulopretamos.Name = "Modulopretamos";
            Modulopretamos.Size = new Size(247, 30);
            Modulopretamos.TabIndex = 6;
            Modulopretamos.Text = "4) Modulo de pretamos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(290, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 131, 230);
            ClientSize = new Size(550, 238);
            Controls.Add(pictureBox1);
            Controls.Add(Modulopretamos);
            Controls.Add(libreria);
            Controls.Add(gestionuser);
            Controls.Add(buscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label buscar;
        private Label gestionuser;
        private Label libreria;
        private Label Modulopretamos;
        private PictureBox pictureBox1;
    }
}