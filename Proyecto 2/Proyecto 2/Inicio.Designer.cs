namespace Proyecto_2
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            Biblioteca = new PictureBox();
            Lector = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Biblioteca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Lector).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Lucida Handwriting", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(274, 27);
            label6.Name = "label6";
            label6.Size = new Size(313, 63);
            label6.TabIndex = 8;
            label6.Text = "San Pedro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(304, 64);
            label5.Name = "label5";
            label5.Size = new Size(0, 45);
            label5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Handwriting", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 27);
            label7.Name = "label7";
            label7.Size = new Size(256, 63);
            label7.TabIndex = 10;
            label7.Text = "Libreria";
            // 
            // Biblioteca
            // 
            Biblioteca.Location = new Point(63, 121);
            Biblioteca.Name = "Biblioteca";
            Biblioteca.Size = new Size(197, 132);
            Biblioteca.TabIndex = 11;
            Biblioteca.TabStop = false;
            Biblioteca.Click += Biblioteca_Click;
            // 
            // Lector
            // 
            Lector.Location = new Point(323, 121);
            Lector.Name = "Lector";
            Lector.Size = new Size(215, 132);
            Lector.TabIndex = 12;
            Lector.TabStop = false;
            Lector.Click += Lector_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Calisto MT", 21.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(85, 256);
            label1.Name = "label1";
            label1.Size = new Size(161, 34);
            label1.TabIndex = 13;
            label1.Text = "Bibliotecario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Calisto MT", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(391, 256);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 14;
            label2.Text = "Lector";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(606, 364);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lector);
            Controls.Add(Biblioteca);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)Biblioteca).EndInit();
            ((System.ComponentModel.ISupportInitialize)Lector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label7;
        private PictureBox Biblioteca;
        private PictureBox Lector;
        private Label label1;
        private Label label2;
    }
}
