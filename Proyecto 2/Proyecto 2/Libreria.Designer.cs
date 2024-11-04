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
            SuspendLayout();
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.BorderSize = 0;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(1, 11);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 37;
            Regresar.UseVisualStyleBackColor = false;
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
            btnSolicitar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnSolicitar.Location = new Point(12, 186);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(260, 49);
            btnSolicitar.TabIndex = 34;
            btnSolicitar.Text = "Solicitar Libro";
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
            label1.Location = new Point(108, 13);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 32;
            label1.Text = "Solicitar Libro";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(12, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(260, 44);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar Libro";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Libreria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 230, 211);
            ClientSize = new Size(561, 358);
            Controls.Add(btnBuscar);
            Controls.Add(Regresar);
            Controls.Add(TxtISBN);
            Controls.Add(label4);
            Controls.Add(btnSolicitar);
            Controls.Add(rchtxtLibros);
            Controls.Add(label1);
            Name = "Libreria";
            Text = "Gestion Libros";
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
    }
}