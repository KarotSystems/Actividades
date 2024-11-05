namespace Proyecto_2
{
    partial class Libreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libreria));
            Regresar = new Button();
            TxtISBN = new TextBox();
            label4 = new Label();
            btnSolicitar = new Button();
            rchtxtLibros = new RichTextBox();
            label1 = new Label();
            btnBuscar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.BorderSize = 0;
            Regresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            Regresar.FlatAppearance.MouseOverBackColor = Color.Teal;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(-2, -1);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 41);
            Regresar.TabIndex = 37;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // TxtISBN
            // 
            TxtISBN.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtISBN.Location = new Point(87, 71);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(185, 30);
            TxtISBN.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 35;
            label4.Text = "ISBN";
            // 
            // btnSolicitar
            // 
            btnSolicitar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            btnSolicitar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSolicitar.FlatStyle = FlatStyle.Flat;
            btnSolicitar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnSolicitar.Location = new Point(8, 262);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(260, 73);
            btnSolicitar.TabIndex = 34;
            btnSolicitar.Text = "Solicitar Libro";
            btnSolicitar.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // rchtxtLibros
            // 
            rchtxtLibros.Location = new Point(299, 16);
            rchtxtLibros.Name = "rchtxtLibros";
            rchtxtLibros.Size = new Size(260, 332);
            rchtxtLibros.TabIndex = 33;
            rchtxtLibros.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(112, 4);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 32;
            label1.Text = "Solicitar Libro";
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(8, 159);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(260, 72);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar Libro";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // Libreria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 230, 211);
            ClientSize = new Size(561, 358);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(Regresar);
            Controls.Add(TxtISBN);
            Controls.Add(label4);
            Controls.Add(btnSolicitar);
            Controls.Add(rchtxtLibros);
            Controls.Add(label1);
            Name = "Libreria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Libros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Regresar;
        private TextBox TxtISBN;
        private Label label4;
        private Button btnSolicitar;
        private RichTextBox rchtxtLibros;
        private Label label1;
        private Button btnBuscar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}