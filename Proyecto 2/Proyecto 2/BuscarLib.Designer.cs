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
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            lbtitulo = new Label();
            lbautor = new Label();
            lbisbn = new Label();
            lbgenero = new Label();
            lbdisponible = new Label();
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
            TxtISBN.Location = new Point(106, 54);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(196, 30);
            TxtISBN.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 35;
            label4.Text = "ISBN";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnAgregar.Location = new Point(327, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(290, 41);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Buscar Libro";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, -4);
            label1.Name = "label1";
            label1.Size = new Size(193, 41);
            label1.TabIndex = 32;
            label1.Text = "Buscar Libro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label6.Location = new Point(12, 288);
            label6.Name = "label6";
            label6.Size = new Size(158, 30);
            label6.TabIndex = 42;
            label6.Text = "Disponibilidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label5.Location = new Point(78, 245);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 41;
            label5.Text = "Genero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(92, 203);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 40;
            label2.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(91, 158);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 39;
            label3.Text = "Autor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label7.Location = new Point(89, 114);
            label7.Name = "label7";
            label7.Size = new Size(81, 30);
            label7.TabIndex = 38;
            label7.Text = "Titulo:";
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            lbtitulo.Location = new Point(167, 114);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(72, 30);
            lbtitulo.TabIndex = 43;
            lbtitulo.Text = "Titulo";
            lbtitulo.Visible = false;
            // 
            // lbautor
            // 
            lbautor.AutoSize = true;
            lbautor.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            lbautor.Location = new Point(169, 158);
            lbautor.Name = "lbautor";
            lbautor.Size = new Size(70, 30);
            lbautor.TabIndex = 44;
            lbautor.Text = "Autor";
            lbautor.Visible = false;
            // 
            // lbisbn
            // 
            lbisbn.AutoSize = true;
            lbisbn.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            lbisbn.Location = new Point(170, 203);
            lbisbn.Name = "lbisbn";
            lbisbn.Size = new Size(69, 30);
            lbisbn.TabIndex = 45;
            lbisbn.Text = "ISBN";
            lbisbn.Visible = false;
            // 
            // lbgenero
            // 
            lbgenero.AutoSize = true;
            lbgenero.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            lbgenero.Location = new Point(170, 245);
            lbgenero.Name = "lbgenero";
            lbgenero.Size = new Size(83, 30);
            lbgenero.TabIndex = 46;
            lbgenero.Text = "Genero";
            lbgenero.Visible = false;
            // 
            // lbdisponible
            // 
            lbdisponible.AutoSize = true;
            lbdisponible.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            lbdisponible.Location = new Point(170, 288);
            lbdisponible.Name = "lbdisponible";
            lbdisponible.Size = new Size(149, 30);
            lbdisponible.TabIndex = 47;
            lbdisponible.Text = "Disponibilidad";
            lbdisponible.Visible = false;
            // 
            // BuscarLib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 207, 240);
            ClientSize = new Size(617, 327);
            Controls.Add(lbdisponible);
            Controls.Add(lbgenero);
            Controls.Add(lbisbn);
            Controls.Add(lbautor);
            Controls.Add(lbtitulo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(Regresar);
            Controls.Add(TxtISBN);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
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
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label lbtitulo;
        private Label lbautor;
        private Label lbisbn;
        private Label lbgenero;
        private Label lbdisponible;
    }
}