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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            label2 = new Label();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            Registro = new Button();
            RpLector = new RadioButton();
            RpBiblio = new RadioButton();
            btnBorrar = new Button();
            rchtxtUser = new RichTextBox();
            Regresar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 177);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(231, 23);
            txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(231, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Lucida Handwriting", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(74, -1);
            label3.Name = "label3";
            label3.Size = new Size(414, 45);
            label3.TabIndex = 10;
            label3.Text = "Libreria San Pedro";
            // 
            // Registro
            // 
            Registro.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Registro.Location = new Point(12, 252);
            Registro.Name = "Registro";
            Registro.Size = new Size(174, 49);
            Registro.TabIndex = 12;
            Registro.Text = "Registrar User";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
            // 
            // RpLector
            // 
            RpLector.AutoSize = true;
            RpLector.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RpLector.Location = new Point(12, 217);
            RpLector.Name = "RpLector";
            RpLector.Size = new Size(83, 29);
            RpLector.TabIndex = 13;
            RpLector.TabStop = true;
            RpLector.Text = "Lector";
            RpLector.UseVisualStyleBackColor = true;
            // 
            // RpBiblio
            // 
            RpBiblio.AutoSize = true;
            RpBiblio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RpBiblio.Location = new Point(106, 217);
            RpBiblio.Name = "RpBiblio";
            RpBiblio.Size = new Size(137, 29);
            RpBiblio.TabIndex = 14;
            RpBiblio.TabStop = true;
            RpBiblio.Text = "Bibliotecario";
            RpBiblio.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnBorrar.Location = new Point(363, 253);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(149, 47);
            btnBorrar.TabIndex = 36;
            btnBorrar.Text = "Borrar User";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // rchtxtUser
            // 
            rchtxtUser.Location = new Point(266, 57);
            rchtxtUser.Name = "rchtxtUser";
            rchtxtUser.Size = new Size(246, 189);
            rchtxtUser.TabIndex = 35;
            rchtxtUser.Text = "";
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.Transparent;
            Regresar.BackgroundImage = (Image)resources.GetObject("Regresar.BackgroundImage");
            Regresar.BackgroundImageLayout = ImageLayout.Stretch;
            Regresar.FlatAppearance.BorderSize = 0;
            Regresar.FlatStyle = FlatStyle.Flat;
            Regresar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            Regresar.Location = new Point(0, -1);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(68, 34);
            Regresar.TabIndex = 37;
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnEditar.Location = new Point(192, 252);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 47);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar User";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 191, 230);
            ClientSize = new Size(528, 311);
            Controls.Add(btnEditar);
            Controls.Add(Regresar);
            Controls.Add(btnBorrar);
            Controls.Add(rchtxtUser);
            Controls.Add(RpBiblio);
            Controls.Add(RpLector);
            Controls.Add(Registro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "RegistroUsuario";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label3;
        private Button Registro;
        private RadioButton RpLector;
        private RadioButton RpBiblio;
        private Button btnBorrar;
        private RichTextBox rchtxtUser;
        private Button Regresar;
        private Button btnEditar;
    }
}