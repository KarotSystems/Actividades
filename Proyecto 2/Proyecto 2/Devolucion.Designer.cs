namespace Proyecto_2
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            Regresar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            Regresar.FlatAppearance.MouseOverBackColor = Color.Teal;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(-1, 0);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 32;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label1.Location = new Point(196, 2);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 33;
            label1.Text = "Devolucion Libro";
            // 
            // Devolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 334);
            Controls.Add(label1);
            Controls.Add(Regresar);
            Name = "Devolucion";
            Text = "Devolucion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Regresar;
        private Label label1;
    }
}