namespace Proyecto_2
{
    partial class EliminarLibr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarLibr));
            btnBorrar = new Button();
            Regresar = new Button();
            TxtISBN = new TextBox();
            label4 = new Label();
            label1 = new Label();
            rchtxtLibros = new RichTextBox();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnBorrar.Location = new Point(36, 165);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 40);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar Libro";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.BorderSize = 0;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(-1, 2);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 35;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // TxtISBN
            // 
            TxtISBN.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtISBN.Location = new Point(14, 96);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(196, 30);
            TxtISBN.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(14, 63);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 33;
            label4.Text = "ISBN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(91, 4);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 32;
            label1.Text = "Eliminar Libro";
            // 
            // rchtxtLibros
            // 
            rchtxtLibros.Location = new Point(259, 12);
            rchtxtLibros.Name = "rchtxtLibros";
            rchtxtLibros.Size = new Size(234, 193);
            rchtxtLibros.TabIndex = 36;
            rchtxtLibros.Text = "";
            // 
            // EliminarLibr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 237);
            ClientSize = new Size(500, 219);
            Controls.Add(rchtxtLibros);
            Controls.Add(Regresar);
            Controls.Add(TxtISBN);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnBorrar);
            Name = "EliminarLibr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarLibr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button Regresar;
        private TextBox TxtISBN;
        private Label label4;
        private Label label1;
        private RichTextBox rchtxtLibros;
    }
}