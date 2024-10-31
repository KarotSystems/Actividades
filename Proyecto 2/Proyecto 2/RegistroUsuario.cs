using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_2
{
    public partial class RegistroUsuario : Form
    {
        public List<User> listaUsuarios = new List<User>();
        public RegistroUsuario()
        {
            InitializeComponent();
            label6.BackColor = Color.Transparent;
            label3.BringToFront();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = "";
            if (RpLector.Checked)
            {
                rol = "Lector";
            }
            else if (RpBiblio.Checked)
            {
                rol = "Bibliotecario";
            }
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete toda la información.");
                return;
            }
            User.Instancia.GuardarUsuario(usuario, contraseña, rol);
        }
    }
}
