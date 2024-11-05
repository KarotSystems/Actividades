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
            pictureBox1 = new PictureBox();
            btnGestionLib = new Button();
            btnPretamos = new Button();
            btnSalir = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Matura MT Script Capitals", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 3);
            label1.Name = "label1";
            label1.Size = new Size(312, 47);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnGestionLib
            // 
            btnGestionLib.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnGestionLib.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnGestionLib.FlatStyle = FlatStyle.Flat;
            btnGestionLib.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionLib.Location = new Point(12, 54);
            btnGestionLib.Name = "btnGestionLib";
            btnGestionLib.Size = new Size(289, 61);
            btnGestionLib.TabIndex = 8;
            btnGestionLib.Text = "1) Solicitar Libros";
            btnGestionLib.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionLib.UseVisualStyleBackColor = true;
            btnGestionLib.Click += btnGestionLib_Click;
            // 
            // btnPretamos
            // 
            btnPretamos.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnPretamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnPretamos.FlatStyle = FlatStyle.Flat;
            btnPretamos.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPretamos.Location = new Point(12, 134);
            btnPretamos.Name = "btnPretamos";
            btnPretamos.Size = new Size(289, 63);
            btnPretamos.TabIndex = 9;
            btnPretamos.Text = "2) Gestión de Préstamos";
            btnPretamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPretamos.UseVisualStyleBackColor = true;
            btnPretamos.Click += btnPretamos_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 219);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(289, 61);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "3) Salir del Programa";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(287, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(287, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(642, 309);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(btnPretamos);
            Controls.Add(btnGestionLib);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnGestionLib;
        private Button btnPretamos;
        private Button btnSalir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}