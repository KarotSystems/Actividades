namespace Proyecto_2
{
    partial class BuscarLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarLib));
            Regresar = new Button();
            TxtISBN = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            rchtxtLibros = new RichTextBox();
            label1 = new Label();
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
            Regresar.Location = new Point(0, -4);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 37;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // TxtISBN
            // 
            TxtISBN.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtISBN.Location = new Point(106, 47);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(196, 30);
            TxtISBN.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(12, 47);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 35;
            label4.Text = "ISBN";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnAgregar.Location = new Point(12, 96);
            btnAgregar.Name = "btnBuscar";
            btnAgregar.Size = new Size(290, 41);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Buscar Libro";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnBuscar_Click;
            // 
            // rchtxtLibros
            // 
            rchtxtLibros.Location = new Point(12, 143);
            rchtxtLibros.Name = "rchtxtLibros";
            rchtxtLibros.Size = new Size(290, 164);
            rchtxtLibros.TabIndex = 33;
            rchtxtLibros.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(123, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 32;
            label1.Text = "Buscar Libro";
            // 
            // BuscarLib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 319);
            Controls.Add(Regresar);
            Controls.Add(TxtISBN);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
            Controls.Add(rchtxtLibros);
            Controls.Add(label1);
            Name = "BuscarLib";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarLib";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Regresar;
        private TextBox TxtISBN;
        private Label label4;
        private Button btnAgregar;
        private RichTextBox rchtxtLibros;
        private Label label1;
    }
}