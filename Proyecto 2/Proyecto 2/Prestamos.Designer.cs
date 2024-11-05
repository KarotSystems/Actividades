namespace Proyecto_2
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            Regresar = new Button();
            rdbtnDisponibildad = new RadioButton();
            TxtGenero = new TextBox();
            TxtISBN = new TextBox();
            TxtAutor = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            rchtxtLibros = new RichTextBox();
            Txttitulo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            Regresar.FlatAppearance.MouseOverBackColor = Color.Cyan;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(-3, -4);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 46;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // rdbtnDisponibildad
            // 
            rdbtnDisponibildad.AutoSize = true;
            rdbtnDisponibildad.Font = new Font("Comic Sans MS", 12F);
            rdbtnDisponibildad.Location = new Point(184, 223);
            rdbtnDisponibildad.Name = "rdbtnDisponibildad";
            rdbtnDisponibildad.Size = new Size(105, 27);
            rdbtnDisponibildad.TabIndex = 45;
            rdbtnDisponibildad.TabStop = true;
            rdbtnDisponibildad.Text = "Disponible";
            rdbtnDisponibildad.UseVisualStyleBackColor = true;
            // 
            // TxtGenero
            // 
            TxtGenero.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtGenero.Location = new Point(93, 177);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(185, 30);
            TxtGenero.TabIndex = 44;
            // 
            // TxtISBN
            // 
            TxtISBN.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtISBN.Location = new Point(93, 133);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(185, 30);
            TxtISBN.TabIndex = 43;
            // 
            // TxtAutor
            // 
            TxtAutor.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAutor.Location = new Point(93, 88);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(185, 30);
            TxtAutor.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label6.Location = new Point(4, 220);
            label6.Name = "label6";
            label6.Size = new Size(149, 30);
            label6.TabIndex = 41;
            label6.Text = "Disponibilidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label5.Location = new Point(4, 175);
            label5.Name = "label5";
            label5.Size = new Size(83, 30);
            label5.TabIndex = 40;
            label5.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(4, 131);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 39;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(4, 86);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 38;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(4, 39);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 37;
            label2.Text = "Titulo";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnEditar.Location = new Point(165, 260);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 73);
            btnEditar.TabIndex = 36;
            btnEditar.Text = "Editar Libro";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnAgregar.Location = new Point(24, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 73);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar Libro";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // rchtxtLibros
            // 
            rchtxtLibros.Location = new Point(295, 39);
            rchtxtLibros.Name = "rchtxtLibros";
            rchtxtLibros.Size = new Size(260, 294);
            rchtxtLibros.TabIndex = 34;
            rchtxtLibros.Text = "";
            // 
            // Txttitulo
            // 
            Txttitulo.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txttitulo.Location = new Point(93, 39);
            Txttitulo.Name = "Txttitulo";
            Txttitulo.Size = new Size(185, 30);
            Txttitulo.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, -2);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 32;
            label1.Text = "Gestion de Pedidos";
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 97, 240);
            ClientSize = new Size(590, 343);
            Controls.Add(Regresar);
            Controls.Add(rdbtnDisponibildad);
            Controls.Add(TxtGenero);
            Controls.Add(TxtISBN);
            Controls.Add(TxtAutor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(rchtxtLibros);
            Controls.Add(Txttitulo);
            Controls.Add(label1);
            Name = "Prestamos";
            Text = "pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Regresar;
        private RadioButton rdbtnDisponibildad;
        private TextBox TxtGenero;
        private TextBox TxtISBN;
        private TextBox TxtAutor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEditar;
        private Button btnAgregar;
        private RichTextBox rchtxtLibros;
        private TextBox Txttitulo;
        private Label label1;
    }
}