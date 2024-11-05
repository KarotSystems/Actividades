namespace Proyecto_2
{
    partial class MenuBiblio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBiblio));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSalir = new Button();
            btnPretamos = new Button();
            btnGestionLib = new Button();
            btnBorrar = new Button();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            btnGestionUsser = new Button();
            pictureBox9 = new PictureBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, -2);
            label2.Name = "label2";
            label2.Size = new Size(310, 40);
            label2.TabIndex = 8;
            label2.Text = "Menú Biblioteca";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(283, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(647, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(283, 195);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(368, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(289, 61);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "6) Salir del Programa";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnPretamos
            // 
            btnPretamos.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnPretamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnPretamos.FlatStyle = FlatStyle.Flat;
            btnPretamos.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPretamos.Location = new Point(12, 195);
            btnPretamos.Name = "btnPretamos";
            btnPretamos.Size = new Size(289, 63);
            btnPretamos.TabIndex = 17;
            btnPretamos.Text = "5) Gestión de Préstamos";
            btnPretamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPretamos.UseVisualStyleBackColor = true;
            btnPretamos.Click += btnPretamos_Click;
            // 
            // btnGestionLib
            // 
            btnGestionLib.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnGestionLib.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnGestionLib.FlatStyle = FlatStyle.Flat;
            btnGestionLib.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionLib.Location = new Point(12, 42);
            btnGestionLib.Name = "btnGestionLib";
            btnGestionLib.Size = new Size(330, 61);
            btnGestionLib.TabIndex = 16;
            btnGestionLib.Text = "1) Libreria";
            btnGestionLib.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionLib.UseVisualStyleBackColor = true;
            btnGestionLib.Click += btnGestionLib_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(368, 42);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(289, 63);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "2) Borrar Libreria";
            btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(647, 41);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 63);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(647, 118);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(59, 63);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 28;
            pictureBox8.TabStop = false;
            // 
            // btnGestionUsser
            // 
            btnGestionUsser.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnGestionUsser.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnGestionUsser.FlatStyle = FlatStyle.Flat;
            btnGestionUsser.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestionUsser.Location = new Point(368, 118);
            btnGestionUsser.Name = "btnGestionUsser";
            btnGestionUsser.Size = new Size(289, 63);
            btnGestionUsser.TabIndex = 27;
            btnGestionUsser.Text = "4) Gestion de Usuarios";
            btnGestionUsser.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionUsser.UseVisualStyleBackColor = true;
            btnGestionUsser.Click += btnGestionUsser_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(283, 118);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(59, 62);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 26;
            pictureBox9.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(12, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(289, 61);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "3) Buscar Libro";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // MenuBiblio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 119, 237);
            ClientSize = new Size(718, 453);
            Controls.Add(pictureBox8);
            Controls.Add(btnGestionUsser);
            Controls.Add(pictureBox9);
            Controls.Add(btnBuscar);
            Controls.Add(pictureBox5);
            Controls.Add(btnBorrar);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(btnPretamos);
            Controls.Add(btnGestionLib);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "MenuBiblio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblotecario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnSalir;
        private Button btnPretamos;
        private Button btnGestionLib;
        private Button btnBorrar;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private Button btnGestionUsser;
        private PictureBox pictureBox9;
        private Button btnBuscar;
    }
}