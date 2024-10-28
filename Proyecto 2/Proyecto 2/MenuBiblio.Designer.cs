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
            Modulopretamos = new Label();
            libreria = new Label();
            gestionuser = new Label();
            buscar = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Modulopretamos
            // 
            Modulopretamos.AutoSize = true;
            Modulopretamos.BackColor = Color.Transparent;
            Modulopretamos.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Modulopretamos.Location = new Point(34, 192);
            Modulopretamos.Name = "Modulopretamos";
            Modulopretamos.Size = new Size(247, 30);
            Modulopretamos.TabIndex = 12;
            Modulopretamos.Text = "4) Modulo de pretamos";
            Modulopretamos.Click += Modulopretamos_Click;
            // 
            // libreria
            // 
            libreria.AutoSize = true;
            libreria.BackColor = Color.Transparent;
            libreria.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libreria.ForeColor = SystemColors.ControlText;
            libreria.Location = new Point(34, 55);
            libreria.Name = "libreria";
            libreria.Size = new Size(123, 30);
            libreria.TabIndex = 11;
            libreria.Text = "1) Libreria";
            libreria.Click += libreria_Click;
            // 
            // gestionuser
            // 
            gestionuser.AutoSize = true;
            gestionuser.BackColor = Color.Transparent;
            gestionuser.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            gestionuser.Location = new Point(34, 147);
            gestionuser.Name = "gestionuser";
            gestionuser.Size = new Size(244, 30);
            gestionuser.TabIndex = 10;
            gestionuser.Text = "3) Gestion de Usuarios";
            gestionuser.Click += gestionuser_Click;
            // 
            // buscar
            // 
            buscar.AutoSize = true;
            buscar.BackColor = Color.Transparent;
            buscar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            buscar.Location = new Point(34, 103);
            buscar.Name = "buscar";
            buscar.Size = new Size(170, 30);
            buscar.TabIndex = 9;
            buscar.Text = "2) Buscar Libro";
            buscar.Click += buscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 9);
            label2.Name = "label2";
            label2.Size = new Size(263, 34);
            label2.TabIndex = 8;
            label2.Text = "Menú Biblioteca";
            // 
            // MenuBiblio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 256);
            Controls.Add(pictureBox1);
            Controls.Add(Modulopretamos);
            Controls.Add(libreria);
            Controls.Add(gestionuser);
            Controls.Add(buscar);
            Controls.Add(label2);
            Name = "MenuBiblio";
            Text = "Biblotecario";
            Load += Biblotecario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Modulopretamos;
        private Label libreria;
        private Label gestionuser;
        private Label buscar;
        private Label label2;
    }
}