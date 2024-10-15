namespace Proyecto_2
{
    partial class RegistroUsuario
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(231, 90);
            label6.TabIndex = 9;
            label6.Text = "Libreria\r\nSan Pedro";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(231, 90);
            label3.TabIndex = 10;
            label3.Text = "Libreria\r\nSan Pedro";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(576, 304);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label3;
    }
}